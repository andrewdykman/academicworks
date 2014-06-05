// Andrew Dykman, Java II
// Lab 8.1, Accessing Database Staff

// Begin Code.
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import javax.swing.*;

import java.sql.*;
import javax.swing.border.*;

public class AccessingDatabaseStaff extends JApplet {
  boolean isStandalone = false;
  JPanel jpDisplay = new JPanel();
  JLabel jlblStatus = new JLabel();
  JPanel jpButtons = new JPanel();
  BorderLayout borderLayout1 = new BorderLayout();
  JPanel jpStaff = new JPanel();
  JButton jbtView = new JButton();
  JButton jbtInsert = new JButton();
  JButton jbtUpdate = new JButton();
  JButton jbtClear = new JButton();
  JPanel jPanel1 = new JPanel();
  JPanel jPanel2 = new JPanel();
  JPanel jPanel3 = new JPanel();
  JPanel jPanel4 = new JPanel();
  JPanel jPanel5 = new JPanel();
  JLabel jLabel2 = new JLabel();
  JLabel jLabel3 = new JLabel();
  JLabel jLabel4 = new JLabel();
  FlowLayout flowLayout1 = new FlowLayout();
  FlowLayout flowLayout2 = new FlowLayout();
  FlowLayout flowLayout3 = new FlowLayout();
  JTextField jtfID = new JTextField();
  JTextField jtfLastName = new JTextField();
  JLabel jLabel5 = new JLabel();
  JTextField jtfFirstName = new JTextField();
  JLabel jLabel6 = new JLabel();
  JTextField jtfmi = new JTextField();
  JTextField jtfAddress = new JTextField();
  JLabel jLabel7 = new JLabel();
  JTextField jtfCity = new JTextField();
  JLabel jLabel8 = new JLabel();
  JTextField jtfState = new JTextField();
  FlowLayout flowLayout4 = new FlowLayout();
  JLabel jLabel9 = new JLabel();
  JTextField jtfTelephone = new JTextField();
  FlowLayout flowLayout5 = new FlowLayout();

  Statement stmt;
  TitledBorder titledBorder1;
  GridLayout gridLayout1 = new GridLayout();

  public void init() {
    try {
      jbInit();
    }
    catch (Exception e) {
      e.printStackTrace();
    }
  }

  private void jbInit() throws Exception {
    titledBorder1 = new TitledBorder("");
    this.setSize(400,300);
    jpDisplay.setLayout(borderLayout1);
    jpStaff.setLayout(gridLayout1);
    jbtView.setText("View");
    jbtView.addActionListener(new java.awt.event.ActionListener() {
      public void actionPerformed(ActionEvent e) {
        jbtView_actionPerformed(e);
      }
    });
    jbtInsert.setText("Insert");
    jbtInsert.addActionListener(new java.awt.event.ActionListener(){
      public void actionPerformed(ActionEvent e) {
        jbtInsert_actionPerformed(e);
      }
    });
    jbtUpdate.setText("Update");
    jbtUpdate.addActionListener(new java.awt.event.ActionListener(){
      public void actionPerformed(ActionEvent e) {
        jbtUpdate_actionPerformed(e);
      }
    });
    jbtClear.setText("Clear");
    jbtClear.addActionListener(new java.awt.event.ActionListener() {
      public void actionPerformed(ActionEvent e) {
        jbtClear_actionPerformed(e);
      }
    });
    jPanel5.setLayout(flowLayout5);
    jPanel4.setLayout(flowLayout4);
    jPanel3.setLayout(flowLayout3);
    jPanel2.setLayout(flowLayout2);
    jPanel1.setLayout(flowLayout1);
    jLabel2.setText("ID");
    jLabel3.setText("Last Name");
    jLabel4.setText("Address");
    flowLayout1.setAlignment(0);
    flowLayout2.setAlignment(0);
    flowLayout3.setAlignment(0);
    jtfID.setColumns(11);
    jtfID.setBackground(Color.yellow);
    jtfLastName.setColumns(10);
    jLabel5.setText("First Name");
    jtfFirstName.setColumns(10);
    jLabel6.setText("mi");
    jtfmi.setColumns(2);
    jtfAddress.setColumns(15);
    jLabel7.setText("City");
    jtfCity.setColumns(15);
    jLabel8.setText("State");
    jtfState.setColumns(2);
    flowLayout4.setAlignment(0);
    jLabel9.setText("Telephone");
    jtfTelephone.setColumns(12);
    flowLayout5.setAlignment(0);
    jlblStatus.setBackground(Color.pink);
    jlblStatus.setText("Connecting ...");
    jpStaff.setBorder(titledBorder1);
    titledBorder1.setTitle("Staff Information");
    gridLayout1.setColumns(1);
    gridLayout1.setRows(5);
    this.getContentPane().add(jpDisplay, BorderLayout.CENTER);
    jpDisplay.add(jpButtons, BorderLayout.SOUTH);
    jpButtons.add(jbtView, null);
    jpButtons.add(jbtInsert, null);
    jpButtons.add(jbtUpdate, null);
    jpButtons.add(jbtClear, null);
    jpDisplay.add(jpStaff, BorderLayout.CENTER);
    jpStaff.add(jPanel1, null);
    jPanel1.add(jLabel2, null);
    jPanel1.add(jtfID, null);
    jpStaff.add(jPanel2, null);
    jPanel2.add(jLabel3, null);
    jPanel2.add(jtfLastName, null);
    jPanel2.add(jLabel5, null);
    jPanel2.add(jtfFirstName, null);
    jPanel2.add(jLabel6, null);
    jPanel2.add(jtfmi, null);
    jpStaff.add(jPanel3, null);
    jpStaff.add(jPanel4, null);
    jPanel4.add(jLabel7, null);
    jPanel4.add(jtfCity, null);
    jPanel4.add(jLabel8, null);
    jPanel4.add(jtfState, null);
    jpStaff.add(jPanel5, null);
    jPanel5.add(jLabel9, null);
    jPanel5.add(jtfTelephone, null);
    jPanel3.add(jLabel4, null);
    jPanel3.add(jtfAddress, null);
    this.getContentPane().add(jlblStatus, BorderLayout.SOUTH);
    initializeDB();
  }

  private void initializeDB() {
    try {
      Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
      Class.forName("com.mysql.jdbc.Driver");
      System.out.println("Driver loaded\n");

      Connection conn = DriverManager.getConnection
        ("jdbc:mysql://localhost/test", "scott", "tiger");
      System.out.println("Database connected\n");
      jlblStatus.setText("Database connected");
      stmt = conn.createStatement();
    }
    catch (Exception ex) {
      jlblStatus.setText("Connection failed: " + ex);
    }
  }

  void jbtInsert_actionPerformed(ActionEvent e) {
    insert();
  }

  void jbtView_actionPerformed(ActionEvent e) {
    view();
  }

  void jbtUpdate_actionPerformed(ActionEvent e) {
    update();
  }

  void jbtClear_actionPerformed(ActionEvent e) {
    clear();
  }
  private void view() {
    String query = "SELECT * FROM Staff WHERE ID = "
      + "'" + jtfID.getText().trim() + "'";

    try {
      ResultSet rs = stmt.executeQuery(query);
      loadToTextField(rs);
    }
    catch(SQLException ex) {
      jlblStatus.setText("Select failed: " + ex);
    }
  }

  private void loadToTextField(ResultSet rs) throws SQLException {
    if (rs.next()) {
      jtfLastName.setText(rs.getString(2));
      jtfFirstName.setText(rs.getString(3));
      jtfmi.setText(rs.getString(4));
      jtfAddress.setText(rs.getString(5));
      jtfCity.setText(rs.getString(6));
      jtfState.setText(rs.getString(7));
      jtfTelephone.setText(rs.getString(8));
      jlblStatus.setText("Record found");
    }
    else
      jlblStatus.setText("Record not found");
  }
  private void insert() {
    String insertStmt =
      "INSERT INTO Staff(ID, LastName, FirstName, mi, Address, " +
      " City, State, Telephone) VALUES('" +
      jtfID.getText().trim() + "','" +
      jtfLastName.getText().trim() + "','" +
      jtfFirstName.getText().trim() + "','" +
      jtfmi.getText().trim() + "','" +
      jtfAddress.getText().trim() + "','" +
      jtfCity.getText().trim() + "','" +
      jtfState.getText().trim() + "','" +
      jtfTelephone.getText().trim() + "');";

    try {
      stmt.executeUpdate(insertStmt);
    }
    catch (SQLException ex) {
      jlblStatus.setText("Insertion failed: " + ex);
    }

    jlblStatus.setText("record inserted");
  }

  private void update() {
    String updateStmt = "UPDATE Staff " +
      "SET LastName = '" + jtfLastName.getText().trim() + "'," +
      "FirstName = '" + jtfFirstName.getText().trim() + "'," +
      "mi = '" + jtfmi.getText().trim() + "'," +
      "Address = '" + jtfAddress.getText().trim() + "'," +
      "City = '" + jtfCity.getText().trim() + "'," +
      "State = '" + jtfState.getText().trim() + "'," +
      "Telephone = '" + jtfTelephone.getText().trim() + "' " +
      "WHERE ID = '" + jtfID.getText().trim() + "'";

    try {
      stmt.executeUpdate(updateStmt);
      jlblStatus.setText("Record updated");
    }
    catch(SQLException ex) {
      jlblStatus.setText("Update failed: " + ex);
    }
  }
  private void clear() {
    jtfID.setText(null);
    jtfLastName.setText(null);
    jtfFirstName.setText(null);
    jtfmi.setText(null);
    jtfAddress.setText(null);
    jtfCity.setText(null);
    jtfState.setText(null);
    jtfTelephone.setText(null);
  }
  public String getAppletInfo() {
    return "Applet Information";
  }
  public String[][] getParameterInfo() {
    return null;
  }
  public static void main(String[] args) {
    AccessingDatabaseStaff applet = new AccessingDatabaseStaff();
    applet.isStandalone = true;
    JFrame frame = new JFrame();
    frame.setDefaultCloseOperation(3);
    frame.setTitle("Accessing Database Staff");
    frame.getContentPane().add(applet, BorderLayout.CENTER);
    applet.init();
    applet.start();
    frame.setSize(400,320);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setLocationRelativeTo(null);
    frame.setVisible(true);
  }
}
// End Code. Huzzah.
