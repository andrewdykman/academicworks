// Andrew Dykman, Java II
// Lab 8.2, Connection Dialog

// Begin Code.
import javax.swing.*;
import javax.swing.border.*;
import java.sql.*;
import java.awt.*;
import java.awt.event.*;

public class ConnectionDialog extends JApplet {
  Connection connection;

  Statement statement;

  public static void main(String[] args) {
    DBConnectionPanel dbConnectPane = new DBConnectionPanel();
    JFrame frame = new JFrame("Connection Dialog");
    frame.setSize(400, 200);
    frame.getContentPane().add(dbConnectPane, BorderLayout.CENTER);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true);
  }
}

class DBConnectionPanel extends JPanel {
  private Connection connection;
  private JLabel jlblConnectionStatus = new JLabel("No connection");

  private JButton jbtConnect = new JButton("Connect to DB");
  private JComboBox jcboDriver = new JComboBox(new String[] {
    "com.mysql.jdbc.Driver", "sun.jdbc.odbc.JdbcOdbcDriver",
    "oracle.jdbc.driver.OracleDriver"});
  private JComboBox jcboURL = new JComboBox(new String[] {
    "jdbc:odbc:Staff",
    "jdbc:microsoft:sqlserver://local:1433"});

  private JTextField jtfUsername = new JTextField();
  private JPasswordField jpfPassword = new JPasswordField();

  public DBConnectionPanel() {
    jcboDriver.setEditable(true);
    jcboURL.setEditable(true);

    JPanel jPanel1 = new JPanel();
    jPanel1.setLayout(new BorderLayout());
    jPanel1.add(jlblConnectionStatus, BorderLayout.WEST);
    jPanel1.add(jbtConnect, BorderLayout.EAST);
    jbtConnect.addActionListener(new ActionListener() {
      public void actionPerformed(ActionEvent evt) {
        connectDB();
      }
    });

    JPanel jPanel3 = new JPanel();
    jPanel3.setLayout(new GridLayout(4, 0));
    jPanel3.add(new JLabel("JDBC Driver"));
    jPanel3.add(new JLabel("Database URL"));
    jPanel3.add(new JLabel("Username"));
    jPanel3.add(new JLabel("Password"));

    JPanel jPanel4 = new JPanel();
    jPanel4.setLayout(new GridLayout(4, 0));
    jPanel4.add(jcboDriver);
    jPanel4.add(jcboURL);
    jPanel4.add(jtfUsername);
    jPanel4.add(jpfPassword);

    JPanel jPanel2 = new JPanel();
    jPanel2.setLayout(new BorderLayout());
    jPanel2.setBorder(new TitledBorder("Enter database information"));
    jPanel2.add(jPanel3, BorderLayout.WEST);
    jPanel2.add(jPanel4, BorderLayout.CENTER);

    this.setLayout(new BorderLayout());
    add(jPanel1, BorderLayout.SOUTH);
    add(jPanel2, BorderLayout.CENTER);
  }

  private void connectDB() {
    String driver = (String)jcboDriver.getSelectedItem();
    String url = (String)jcboURL.getSelectedItem();
    String username = jtfUsername.getText().trim();
    String password = new String(jpfPassword.getPassword());

    try {
      Class.forName(driver);
      connection = DriverManager.getConnection(
        url, username, password);
      jlblConnectionStatus.setText("Connected to " + url);
    }
    catch (java.lang.Exception ex) {
      ex.printStackTrace();
    }
  }
  public Connection getConnection() {
    return connection;
  }
}
// End Code. Huzzah!

