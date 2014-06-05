// Andrew Dykman, Java II
// Lab 6.2

// Begin Code.
import java.awt.*;
import java.awt.event.*;
import java.util.*;
import javax.swing.*;

public class tabbedPane extends JApplet implements ActionListener {
  private CardLayout queue = new CardLayout();
  private JPanel cardPanel = new JPanel();
  private JComboBox jcboIntRational = new JComboBox(new Object[] {"INTEGER OPERATION", "RATIONAL OPERATION"});

  public tabbedPane() {
    JPanel intPanel = new IntPanel();

    JPanel rationalPanel = new RationalPanel();

    cardPanel.setLayout(queue);
    cardPanel.add(intPanel, "INTEGER");
    cardPanel.add(rationalPanel, "RATIONAL");

    getContentPane().setLayout(new BorderLayout());
    getContentPane().add(jcboIntRational, BorderLayout.NORTH);
    getContentPane().add(cardPanel, BorderLayout.CENTER);

    jcboIntRational.addActionListener(this);
  }

  public void actionPerformed(ActionEvent e) {
    if (jcboIntRational.getSelectedItem().equals("INTEGER OPERATION")) {
      queue.first(cardPanel);
    }
    else if (jcboIntRational.getSelectedItem().equals("RATIONAL OPERATION")) {
      queue.last(cardPanel);
    }
  }

  public static void main(String[] args) {
    tabbedPane applet = new tabbedPane();
    JFrame frame = new JFrame();
    frame.setTitle("TABBED-PANE");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(400, 320);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setLocationRelativeTo(null);
    frame.setVisible(true);
  }
}


class IntPanel extends CalculationPanel {
  IntPanel() {
    super("INTEGER CALCULATION");
  }

  void add() {
    int result = getNum1() + getNum2();
    tfResult.setText(String.valueOf(result));
  }

  void subtract() {
    int result = getNum1() - getNum2();
    tfResult.setText(String.valueOf(result));
  }

  void multiply() {
    int result = getNum1() * getNum2();
    tfResult.setText(String.valueOf(result));
  }

  void divide() {
    int result = getNum1() / getNum2();
    tfResult.setText(String.valueOf(result));
  }

  private int getNum1() {
    int num1 = Integer.parseInt(tfNum1.getText().trim());
    return num1;
  }

  private int getNum2() {
    int num2 = Integer.parseInt(tfNum2.getText().trim());
    return num2;
  }
}


class RationalPanel extends CalculationPanel {
  RationalPanel() {
    super("RATIONAL CALCULATION");
  }

  void add() {
    Rational num1 = getNum1();
    Rational num2 = getNum2();
    Rational result = num1.add(num2);
    tfResult.setText(result.toString());
  }

  void subtract() {
    Rational num1 = getNum1();
    Rational num2 = getNum2();
    Rational result = num1.subtract(num2);
    tfResult.setText(result.toString());
  }

  void multiply() {
    Rational num1 = getNum1();
    Rational num2 = getNum2();
    Rational result = num1.multiply(num2);
    tfResult.setText(result.toString());
  }

  void divide() {
    Rational num1 = getNum1();
    Rational num2 = getNum2();
    Rational result = num1.divide(num2);
    tfResult.setText(result.toString());
  }

  Rational getNum1() {
    StringTokenizer st1 = new
      StringTokenizer(tfNum1.getText().trim(), "/");
    int numer1 = Integer.parseInt(st1.nextToken());
    int denom1 = Integer.parseInt(st1.nextToken());
    return new Rational(numer1, denom1);
  }

  Rational getNum2() {
    StringTokenizer st2 = new
      StringTokenizer(tfNum2.getText().trim(), "/");
    int numer2 = Integer.parseInt(st2.nextToken());
    int denom2 = Integer.parseInt(st2.nextToken());
    return new Rational(numer2, denom2);
  }
}

abstract class CalculationPanel extends JPanel implements
  ActionListener {
  private JPanel p0 = new JPanel();
  private JPanel p1 = new JPanel();
  private JPanel p2 = new JPanel();
  JTextField tfNum1, tfNum2, tfResult;
  private JButton jbtAdd, jbtSub, jbtMul, jbtDiv;

  public CalculationPanel(String title) {
    p0.add(new JLabel(title));

    p1.setLayout(new FlowLayout());
    p1.add(new JLabel("NUMBER 1"));
    p1.add(tfNum1 = new JTextField(" ", 3));
    p1.add(new JLabel("NUMBER 2"));
    p1.add(tfNum2 = new JTextField(" ", 3));
    p1.add(new JLabel("YOUR RESULT"));
    p1.add(tfResult = new JTextField(" ", 4));
    tfResult.setEditable(false);

    JPanel p2 = new JPanel();
    p2.setLayout(new FlowLayout());
    p2.add(jbtAdd = new JButton("ADD"));
    p2.add(jbtSub = new JButton("SUBTRACT"));
    p2.add(jbtMul = new JButton("MULTIPLY"));
    p2.add(jbtDiv = new JButton("DIVIDE"));

    setLayout(new BorderLayout());
    add("NORTH", p0);
    add("CENTER", p1);
    add("SOUTH", p2);

    jbtAdd.addActionListener(this);
    jbtSub.addActionListener(this);
    jbtMul.addActionListener(this);
    jbtDiv.addActionListener(this);
  }

  public void actionPerformed(ActionEvent e) {
    String actionCommand = e.getActionCommand();
    if (e.getSource() instanceof JButton) {
      if ("ADD".equals(actionCommand)) {
        add();
      }
      else if ("SUBTRACT".equals(actionCommand)) {
        subtract();
      }
      else if ("MULTIPLY".equals(actionCommand)) {
        multiply();
      }
      else if ("DIVIDE".equals(actionCommand)) {
        divide();
      }
    }
  }
  abstract void add();
  abstract void subtract();
  abstract void multiply();
  abstract void divide();
}
// End Code. Huzzah.