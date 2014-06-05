// Andrew Dykman, Java II
// Lab 9.1, Scrollable Result Set

// Begin Code.
 import java.awt.*;
   import java.awt.event.*;
   import java.applet.*;
   import javax.swing.*;
   import java.sql.*;

   public class ScrollableResultSet extends javax.swing.JApplet {
      ResultSet resultSet;
      int currentRowNumber;
      public ScrollableResultSet() {
         initComponents();
         initializeDB();
      }
      private void initComponents() {
         jPanel1 = new javax.swing.JPanel();
         jbtFirst = new javax.swing.JButton();
         jbtNext = new javax.swing.JButton();
         jbtPrior = new javax.swing.JButton();
         jbtLast = new javax.swing.JButton();
         jbtInsert = new javax.swing.JButton();
         jbtDelete = new javax.swing.JButton();
         jbtUpdate = new javax.swing.JButton();
         jlblStatus = new javax.swing.JLabel();
         jpAddress = new javax.swing.JPanel();
         jPanel2 = new javax.swing.JPanel();
         jLabel1 = new javax.swing.JLabel();
         jtfFirstName = new javax.swing.JTextField();
         jLabel2 = new javax.swing.JLabel();
         jtfMI = new javax.swing.JTextField();
         jLabel3 = new javax.swing.JLabel();
         jtfLastName = new javax.swing.JTextField();
         jPanel3 = new javax.swing.JPanel();
         jLabel4 = new javax.swing.JLabel();
         jtfStreet = new javax.swing.JTextField();
         jPanel4 = new javax.swing.JPanel();
         jLabel5 = new javax.swing.JLabel();
         jtfCity = new javax.swing.JTextField();
         jLabel6 = new javax.swing.JLabel();
         jtfState = new javax.swing.JTextField();
         jLabel7 = new javax.swing.JLabel();
         jtfZip = new javax.swing.JTextField();
         jPanel5 = new javax.swing.JPanel();
         jLabel8 = new javax.swing.JLabel();
         jtfTelephone = new javax.swing.JTextField();
         jPanel6 = new javax.swing.JPanel();
         jLabel9 = new javax.swing.JLabel();
         jtfEmail = new javax.swing.JTextField();
         jbtFirst.setText("FIRST");
         jbtFirst.addActionListener(
               new java.awt.event.ActionListener() {
                  public void actionPerformed(java.awt.event.ActionEvent evt) {
                     jbtFirstActionPerformed(evt);
                  }
               });
         jPanel1.add(jbtFirst);
         jbtNext.setText("NEXT");
         jbtNext.addActionListener(
               new java.awt.event.ActionListener() {
                  public void actionPerformed(java.awt.event.ActionEvent evt) {
                     jbtNextActionPerformed(evt);
                  }
               });
         jPanel1.add(jbtNext);
         jbtPrior.setText("PRIOR");
         jPanel1.add(jbtPrior);
         jbtLast.setText("LAST");
         jbtLast.addActionListener(
               new java.awt.event.ActionListener() {
                  public void actionPerformed(java.awt.event.ActionEvent evt) {
                     jbtLastActionPerformed(evt);
                  }
               });
         jPanel1.add(jbtLast);
         jbtInsert.setText("INSERT");
         jbtInsert.addActionListener(
               new java.awt.event.ActionListener() {
                  public void actionPerformed(java.awt.event.ActionEvent evt) {
                     jbtInsertActionPerformed(evt);
                  }
               });
         jPanel1.add(jbtInsert);
         jbtDelete.setText("DELETE");
         jbtDelete.addActionListener(
               new java.awt.event.ActionListener() {
                  public void actionPerformed(java.awt.event.ActionEvent evt) {
                     jbtDeleteActionPerformed(evt);
                  }
               });
         jPanel1.add(jbtDelete);
         jbtUpdate.setText("UPDATE");
         jbtUpdate.addActionListener(
               new java.awt.event.ActionListener() {
                  public void actionPerformed(java.awt.event.ActionEvent evt) {
                     jbtUpdateActionPerformed(evt);
                  }
               });
         jPanel1.add(jbtUpdate);
         getContentPane().add(jPanel1, java.awt.BorderLayout.NORTH);
         jlblStatus.setText("JLABEL1");
         getContentPane().add(jlblStatus, java.awt.BorderLayout.SOUTH);
         jpAddress.setLayout(new java.awt.GridLayout(5, 0));
         jPanel2.setLayout(new
            java.awt.FlowLayout(java.awt.FlowLayout.LEFT));
         jLabel1.setText("FIRST NAME");
         jPanel2.add(jLabel1);
         jtfFirstName.setColumns(10);
         jPanel2.add(jtfFirstName);
         jLabel2.setText("MI");
         jPanel2.add(jLabel2);
         jtfMI.setColumns(2);
         jPanel2.add(jtfMI);
         jLabel3.setText("LAST NAME");
         jPanel2.add(jLabel3);
         jtfLastName.setColumns(15);
         jPanel2.add(jtfLastName);
         jpAddress.add(jPanel2);
         jPanel3.setLayout(new
            java.awt.FlowLayout(java.awt.FlowLayout.LEFT));
         jLabel4.setText("STREET");
         jPanel3.add(jLabel4);
         jtfStreet.setColumns(40);
         jPanel3.add(jtfStreet);
         jpAddress.add(jPanel3);
         jPanel4.setLayout(new
            java.awt.FlowLayout(java.awt.FlowLayout.LEFT));
         jLabel5.setText("CITY");
         jPanel4.add(jLabel5);
         jtfCity.setColumns(15);
         jPanel4.add(jtfCity);
         jLabel6.setText("STATE");
         jPanel4.add(jLabel6);
         jtfState.setColumns(2);
         jPanel4.add(jtfState);
         jLabel7.setText("ZIP");
         jPanel4.add(jLabel7);
         jtfZip.setColumns(5);
         jPanel4.add(jtfZip);
         jpAddress.add(jPanel4);
         jPanel5.setLayout(new
            java.awt.FlowLayout(java.awt.FlowLayout.LEFT));
         jLabel8.setText("TELEPHONE");
         jPanel5.add(jLabel8);
         jtfTelephone.setColumns(12);
         jPanel5.add(jtfTelephone);
         jpAddress.add(jPanel5);
         jPanel6.setLayout(new
            java.awt.FlowLayout(java.awt.FlowLayout.LEFT));
         jLabel9.setText("EMAIL");
         jPanel6.add(jLabel9);
         jtfEmail.setColumns(25);
         jPanel6.add(jtfEmail);
         jpAddress.add(jPanel6);
         getContentPane().add(jpAddress, java.awt.BorderLayout.CENTER);
      }
      private void jbtUpdateActionPerformed(java.awt.event.ActionEvent evt)
      {
         try
         {
            updateRecord(); 
            resultSet.updateRow();
         }
            catch (Exception ex)
            {
               jlblStatus.setText(ex.toString());
            }
      }
      private void jbtDeleteActionPerformed(java.awt.event.ActionEvent evt)
      {
         try {
            resultSet.deleteRow();
            jlblStatus.setText("DELETE SUCCEEDED");
         }
            catch (Exception ex) {
               jlblStatus.setText(ex.toString());
            }
      }
      private void jbtInsertActionPerformed(java.awt.event.ActionEvent evt)
      {
         try {
            insert();
            jlblStatus.setText("INSERT SUCCEEDED");
         }
            catch (SQLException ex) {
               jlblStatus.setText(ex.getMessage());
            }
      }
      private void jbtLastActionPerformed(java.awt.event.ActionEvent evt)
      {
         try {
            if (resultSet.isFirst())
               jlblStatus.setText("THIS IS ALREADY THE FIRST ROW!");
            else {
               resultSet.previous();
               showRecord();
            }
         }
            catch (Exception ex) {
               jlblStatus.setText(ex.toString());
            }
      }
      private void jbtNextActionPerformed(java.awt.event.ActionEvent evt)
      {
         try {
            if (resultSet.isLast())
               jlblStatus.setText("THIS IS ALREADY THE LAST ROW!");
            else {
               resultSet.next();
               showRecord();
            }
         }
            catch (Exception ex) {
               jlblStatus.setText(ex.toString());
            }
      }
      private void jbtFirstActionPerformed(java.awt.event.ActionEvent evt)
      {
         try {
            if (resultSet.first())
               showRecord();
            else
               jlblStatus.setText("THERE IS NO ROW IN THE RESULT SET!");
         }
            catch (Exception ex) {
               jlblStatus.setText(ex.toString());
            }
      }
      private void initializeDB() {
         try {
            Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
            System.out.println("DRIVER LOADED");
            Connection connection = DriverManager.getConnection
               ("jdbc:odbc:Staff", "", "");
            if (connection != null)
               System.out.println("DATABASE CONNECTED");
            Statement statement = connection.createStatement
               (ResultSet.TYPE_SCROLL_SENSITIVE,
               ResultSet.CONCUR_UPDATABLE);
            resultSet = statement.executeQuery("SELECT * FROM ADDRESS");
            resultSet.first();
            showRecord();
         }
            catch (Exception ex) {
               jlblStatus.setText(ex.toString());
            }
      }
      private void showRecord() throws Exception {
         jtfFirstName.setText(resultSet.getString("FIRSTNAME"));
         jtfLastName.setText(resultSet.getString("LASTNAME"));
         jtfMI.setText(resultSet.getString("MI"));
         jtfStreet.setText(resultSet.getString("ADDRESS"));
         jtfCity.setText(resultSet.getString("CITY"));
         jtfState.setText(resultSet.getString("STATE"));
         jtfTelephone.setText(resultSet.getString("PHONE"));
         jtfZip.setText(resultSet.getString("ZIP"));
         jtfEmail.setText(resultSet.getString("EMAIL"));
         currentRowNumber = resultSet.getRow();
         jlblStatus.setText("CURRENT ROW NUMBER: " + currentRowNumber);
      }
      public static void main(String[] args) {
         ScrollableResultSet applet = new ScrollableResultSet();
         JFrame frame = new JFrame();
         frame.setDefaultCloseOperation(3);
         frame.setTitle("Scrollable Result Set");
         frame.getContentPane().add(applet, BorderLayout.CENTER);
         applet.init();
         applet.start();
         frame.pack();
         Dimension d = Toolkit.getDefaultToolkit().getScreenSize();
         frame.setLocation((d.width - frame.getSize().width) / 2, (d.height
            - frame.getSize().height) / 2);
         frame.setVisible(true);
      }
      protected void insert() throws SQLException {
         updateRecord();
         resultSet.insertRow();
         resultSet.moveToCurrentRow();
      }
      protected void updateRecord() throws SQLException {
         resultSet.updateString("FIRSTNAME",
            jtfFirstName.getText().trim());
         resultSet.updateString("MI", jtfMI.getText().trim());
         resultSet.updateString("LASTNAME", jtfLastName.getText().trim());
         resultSet.updateString("ADDRESS", jtfStreet.getText().trim());
         resultSet.updateString("CITY", jtfCity.getText().trim());
         resultSet.updateString("ZIP", jtfZip.getText().trim());
         resultSet.updateString("PHONE",
            jtfTelephone.getText().trim());
         resultSet.updateString("EMAIL", jtfEmail.getText().trim());
      }
      private javax.swing.JTextField jtfStreet;
      private javax.swing.JTextField jtfLastName;
      private javax.swing.JPanel jPanel6;
      private javax.swing.JPanel jPanel5;
      private javax.swing.JPanel jPanel4;
      private javax.swing.JPanel jPanel3;
      private javax.swing.JTextField jtfMI;
      private javax.swing.JPanel jPanel2;
      private javax.swing.JPanel jPanel1;
      private javax.swing.JButton jbtLast;
      private javax.swing.JButton jbtPrior;
      private javax.swing.JTextField jtfCity;
      private javax.swing.JTextField jtfZip;
      private javax.swing.JButton jbtUpdate;
      private javax.swing.JTextField jtfEmail;
      private javax.swing.JTextField jtfFirstName;
      private javax.swing.JLabel jlblStatus;
      private javax.swing.JTextField jtfState;
      private javax.swing.JButton jbtInsert;
      private javax.swing.JButton jbtFirst;
      private javax.swing.JLabel jLabel9;
      private javax.swing.JButton jbtNext;
      private javax.swing.JLabel jLabel8;
      private javax.swing.JPanel jpAddress;
      private javax.swing.JLabel jLabel7;
      private javax.swing.JLabel jLabel6;
      private javax.swing.JLabel jLabel5;
      private javax.swing.JLabel jLabel4;
      private javax.swing.JLabel jLabel3;
      private javax.swing.JTextField jtfTelephone;
      private javax.swing.JLabel jLabel2;
      private javax.swing.JLabel jLabel1;
      private javax.swing.JButton jbtDelete;
   }
// End Code. Huzzah!