// Andrew Dykman, Lab 7.2
// JFileChooserthingy

// Begin Code.
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class JFileChoice extends JFrame {

public JFileChoice() {
 super("JFileChooserThingy");
 setSize(350, 200);
 setDefaultCloseOperation(EXIT_ON_CLOSE);

 Container c = getContentPane();
 c.setLayout(new FlowLayout());
 
 JButton openButton = new JButton("Open");
 final JLabel statusbar = 
              new JLabel("Output of your selection will go here");

 openButton.addActionListener(new ActionListener() {
   public void actionPerformed(ActionEvent ae) {
     JFileChooser chooser = new JFileChooser();
     chooser.setMultiSelectionEnabled(true);
     int option = chooser.showOpenDialog(JFileChoice.this);
     if (option == JFileChooser.APPROVE_OPTION) {
       File[] sf = chooser.getSelectedFiles();
       String filelist = "nothing";
       if (sf.length > 0) filelist = sf[0].getName();
       for (int i = 1; i < sf.length; i++) {
         filelist += ", " + sf[i].getName();
       }
       statusbar.setText("You chose " + filelist);
     }
     else {
       statusbar.setText("You canceled.");
     }
   }
 });

 c.add(openButton);
 c.add(statusbar);
}

public static void main(String args[]) {
 JFileChoice sfc = new JFileChoice();
 sfc.setVisible(true);
}
}
// End Code. Huzzah!