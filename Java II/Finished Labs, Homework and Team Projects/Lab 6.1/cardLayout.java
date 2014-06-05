// Andrew Dykman, Java II
// Lab 6.1

// Begin Code.
import java.awt.*;
import java.awt.Event.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.*;
import javax.swing.*;

public class cardLayout extends JApplet implements ActionListener {
private CardLayout queue = new CardLayout();
private JPanel cardPanel = new JPanel();
private JMenuItem jmiInt, jmiRat, jmiClose;
private JComboBox jcboIntRational = new JComboBox(new Object[]{"Integer Operation", "Rational Operation"});
public cardLayout(){
JMenuBar jmb = new JMenuBar();
JMenu operationMenu = new JMenu("Operation", false);
jmb.add(operationMenu);
JMenu exitMenu = new JMenu("Exit", true);
jmb.add(exitMenu);
operationMenu.add(jmiInt = new JMenuItem("Integer"));
operationMenu.add(jmiRat = new JMenuItem("Rational"));
exitMenu.add(jmiClose = new JMenuItem("Close"));
JPanel intPanel = new IntPanel();
JPanel rationalPanel = new RationalPanel();
cardPanel.setLayout(queue);
cardPanel.add(intPanel, "Integer");
cardPanel.add(rationalPanel, "Rational");
getContentPane().setLayout(new BorderLayout());
getContentPane().add(jcboIntRational, BorderLayout.NORTH);
getContentPane().add(cardPanel, BorderLayout.CENTER);
jcboIntRational.addActionListener(this);
}
public void actionPerformed(ActionEvent e) {
if(jcboIntRational.getSelectedItem().equals("Integer Operation"))
queue.first(cardPanel);
else if (jcboIntRational.getSelectedItem().equals("Rational Operation"))
queue.last(cardPanel);
}
public static void main(String[] args){
cardLayout applet = new cardLayout();
JFrame frame = new JFrame();
frame.setDefaultCloseOperation(3);
frame.setTitle("Using CardLayout");
frame.getContentPane().add(applet, BorderLayout.CENTER);
applet.init();
applet.start();
frame.setSize(400,300);
Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
frame.setLocation((d.width - frame.getSize().width)/2, (d.height - frame.getSize().height)/2);
frame.setVisible(true);
}
}

class IntPanel extends CalculationPanel {
IntPanel() {
super("Integer Calculation");
}
void add(){
int result = getNum1() + getNum2();
tfResult.setText(String.valueOf(result));
}
void subtract(){
int result = getNum1() - getNum2();
tfResult.setText(String.valueOf(result));
}
void multiply(){
int result = getNum1() * getNum2();
tfResult.setText(String.valueOf(result));
}
void divide(){
int result = getNum1() / getNum2();
tfResult.setText(String.valueOf(result));
}
private int getNum1() {
int num1 = Integer.parseInt(tfNum1.getText().trim());
return num1
}
private int getNum2() {
int num2 = Integer.parseInt(tfNum2.getText().trim());
return num2
}
}

class RationalPanel extends CalculationPanel {
RationalPanel() {
super("Rational Calculation");
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
StringTokenizer st1 = new StringTokenizer(tfNum1.getText().trim, "/");
int numer1 = Integer.parseInt(st1.nextToken());
int denom1 = Integer.parseInt(st1.nextToken());
return new Rational(numer1, denom1);
}
Rational getNum2() {
StringTokenizer st1 = new StringTokenizer(tfNum2.getText().trim, "/");
int numer2 = Integer.parseInt(st1.nextToken());
int denom2 = Integer.parseInt(st1.nextToken());
return new Rational(numer2, denom2);
}
}

abstract class CalculationPanel extends JPanel implements ActionListener{
private JPanel p0 = new JPanel();
private JPanel p1 = new JPanel();
private JPanel p2 = new JPanel();
JTextField tfNum1, tfNum2, tfResult;
private JButton jbtAdd, jbtSub, jbtMul, jbtDiv;
public CalculationPanel(String title){
p0.add(new JLabel(title));
p1.setLayout(new FlowLayout());
p1.add(new JLabel("Number 1"));
p1.add(tfNum1 = new JTextField(" ", 3));
p1.add(new JLabel("Number 2"));
p1.add(tfNum2 = new JTextField(" ", 3));
p1.add(new JLabel("Result"));
p1.add(tfResult = new JTextField(" ", 4));
tfResult.setEditable(false);
p2.setLayout(new FlowLayout());
p2.add(jbtAdd = new JButton("Add"));
p2.add(jbtSub = new JButton("Subtract"));
p2.add(jbtMul = new JButton("Multiply"));
p2.add(jbtDiv = new JButton("Divide"));
setLayout(new BorderLayout());
add("North", p0);
add("Center", p1);
add("South", p2);
jbtAdd.addActionListener(this);
jbtSub.addActionListener(this);
jbtMul.addActionListener(this);
jbtDiv.addActionListener(this);
}
public void actionPerformed(ActionEvent e){
String actionCommand = e.getActionCommand();
if(e.getSource() instanceof JButton) {
if("Add".equals(actionCommand))
add();
else if("Subtract".equals(actionCommand))
subtract();
else if("Multiply".equals(actionCommand))
multiply();
else if("Divide".equals(actionCommand))
divide();
}
}
abstract void add();
abstract void subtract();
abstract void multiply();
abstract void divide();
}
// End Code. Huzzah.