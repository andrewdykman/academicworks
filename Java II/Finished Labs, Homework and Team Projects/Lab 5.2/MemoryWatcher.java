// Lab 5.2, Andrew Dykman
// Memory Watcher
// Java II

// Begin Code.
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import javax.swing.*;
import java.util.*;

public class MemoryWatcher extends JApplet implements MemoryListener {
  boolean isStandalone = false;
  private MemoryWatch memoryWatch1 = new MemoryWatch();
  private JScrollPane jScrollPane1 = new JScrollPane();
  private JTextArea jTextArea1 = new JTextArea();

  public void init() {
    this.setSize(new Dimension(400,300));
    jTextArea1.setText("jTextArea1");
    memoryWatch1.addMemoryListener(new MemoryListener() {
      public void sufficientMemory(MemoryEvent e) {
      }

      public void insufficientMemory(MemoryEvent e) {
        memoryWatch1_insufficientMemory(e);
      }
    });

    memoryWatch1.addMemoryListener(new MemoryListener() {
      public void sufficientMemory(MemoryEvent e) {
        memoryWatch1_sufficientMemory(e);
      }

      public void insufficientMemory(MemoryEvent e) {
      }
    });
    this.getContentPane().add(jScrollPane1, BorderLayout.CENTER);
    jScrollPane1.getViewport().add(jTextArea1, null);
  }

  public static void main(String[] args) {
    MemoryWatcher applet = new MemoryWatcher();
    applet.isStandalone = true;
    JFrame frame = new JFrame();
    frame.setTitle("MEMORY WATCHER");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(400,320);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
    frame.setLocation((d.width - frame.getSize().width) / 2, (d.height - frame.getSize().height) / 2);
    frame.setVisible(true);
  }

  public void sufficientMemory(MemoryEvent e) {
    jTextArea1.setText("SUFFICIENT MEMORY");
    jTextArea1.append("High Limit: " + memoryWatch1.getHighLimit()+"\n");
    jTextArea1.append("Free: " + e.freeMemory() + "\n");
    jTextArea1.append("Total: " + e.totalMemory() + "\n");
  }

  public void insufficientMemory(MemoryEvent e) {
    jTextArea1.setText("INSUFFICIENT MEMORY\n");
    jTextArea1.append("Low Limit: " + memoryWatch1.getLowLimit()+"\n");
    jTextArea1.append("Free: " + e.freeMemory() + "\n");
    jTextArea1.append("Total: " + e.totalMemory() + "\n");
  }

  void memoryWatch1_insufficientMemory(MemoryEvent e) {
    insufficientMemory(e);
  }

  void memoryWatch1_sufficientMemory(MemoryEvent e) {
    sufficientMemory(e);
  }
}

interface MemoryListener extends java.util.EventListener {
  public void sufficientMemory(MemoryEvent e);

  public void insufficientMemory(MemoryEvent e);
}

class MemoryEvent extends java.util.EventObject {
  private Runtime runtime = Runtime.getRuntime();

  public MemoryEvent(Object o) {
    super(o);
  }

  public long freeMemory() {
    return runtime.freeMemory();
  }

  public long totalMemory() {
    return runtime.totalMemory();
  }
}

class MemoryWatch implements Runnable {
  private int highLimit = 700000;
  private int lowLimit = 200000;

  private Runtime runtime = Runtime.getRuntime();

  private Thread thread;
  private transient Vector memoryListeners;

  public MemoryWatch() {
    thread = new Thread(this);
    thread.start();
  }

  public void run() {
    while (true) {
      try {
        Thread.sleep(1000);
      }
      catch (InterruptedException e)
      {  }

      System.out.println("TOTAL MEMORY: " + runtime.totalMemory());
      System.out.println("FREE MEMORY: " + runtime.freeMemory());

      if (runtime.freeMemory() > highLimit) {
        MemoryEvent e = new MemoryEvent(this);
        fireSufficientMemory(e);
      }

      if (runtime.freeMemory() < lowLimit) {
        MemoryEvent e = new MemoryEvent(this);
        fireInsufficientMemory(e);
      }
    }
  }

  public static void main(String[] args) {
    MemoryWatch memoryWatch1 = new MemoryWatch();
  }

  public void setHighLimit(int newHighLimit) {
    highLimit = newHighLimit;
  }

  public int getHighLimit() {
    return highLimit;
  }

  public void setLowLimit(int newLowLimit) {
    lowLimit = newLowLimit;
  }

  public int getLowLimit() {
    return lowLimit;
  }

  public synchronized void removeMemoryListener(MemoryListener l) {
    if(memoryListeners != null && memoryListeners.contains(l)) {
      Vector v = (Vector) memoryListeners.clone();
      v.removeElement(l);
      memoryListeners = v;
    }
  }

  public synchronized void addMemoryListener(MemoryListener l) {
    Vector v = memoryListeners == null ? new Vector(2) : (Vector) memoryListeners.clone();
    if(!v.contains(l)) {
      v.addElement(l);
      memoryListeners = v;
    }
  }

  protected void fireSufficientMemory(MemoryEvent e) {
    if(memoryListeners != null) {
      Vector listeners = memoryListeners;
      int count = listeners.size();
      for (int i = 0; i < count; i++) {
        ((MemoryListener) listeners.elementAt(i)).sufficientMemory(e);
      }
    }
  }

  protected void fireInsufficientMemory(MemoryEvent e) {
    if(memoryListeners != null) {
      Vector listeners = memoryListeners;
      int count = listeners.size();
      for (int i = 0; i < count; i++) {
        ((MemoryListener) listeners.elementAt(i)).insufficientMemory(e);
      }
    }
  }
}
// End Code. Huzzah!