// Andrew Dykman
// Lab 3.1 - 1000 Threads with Synchronization

// Begin Code
import java.util.concurrent.*;

public class Threads2 {
  private Integer sum = new Integer(0);

  public synchronized static void main(String[] args) {
    Threads2 test = new Threads2();
    System.out.println("What is sum ? " + test.sum);
  }

  public Threads2() {
    ExecutorService executor = Executors.newFixedThreadPool(1000);
  
    System.out.println("with synchronization .......");
    for (int i = 1; i <=1000; i++) {
      executor.execute(new SumTask2());
      System.out.println("At thread " + i + " sum = " + sum + ", "); 
    }

    executor.shutdown();

    while(!executor.isTerminated()) {
    }
  }
  class SumTask2 implements Runnable {
    public synchronized void run() {
      int value = sum.intValue() + 1;
      sum = new Integer(value);
    }
  }
}
// End Code. Huzzah!