// Andrew Dykman, Java II
// Lab 7.1
// Action Flags

// Begin Code.
   import javax.swing.*;
   import java.awt.*;
   import java.awt.event.*;

   public class Actions extends JApplet{
      private ImageIcon caImageIcon = new ImageIcon(getClass().getResource("caIcon.gif"));
      private ImageIcon usImageIcon = new ImageIcon(getClass().getResource("usIcon.gif"));
  
      private JLabel jlblImage = new JLabel(caImageIcon, JLabel.CENTER);
      private FlowLayout flowLayout = new FlowLayout();
  
      public Actions(){
     
         Action caAction = new MyAction("CANADA", caImageIcon);
         Action usAction = new MyAction("UNITED STATES", usImageIcon);
     
         JMenuBar jMenuBar1 = new JMenuBar();
         JMenu jmenuFlag = new JMenu("FLAGS");
         setJMenuBar(jMenuBar1);
         jMenuBar1.add(jmenuFlag);
     
         jmenuFlag.add(caAction);
         jmenuFlag.add(usAction);
     
         JToolBar jToolBar1 = new JToolBar(JToolBar.VERTICAL);
         jToolBar1.setBorder(BorderFactory.createLineBorder(Color.red));
     
         jToolBar1.add(caAction);
         jToolBar1.add(usAction);
     
         getContentPane().add(jToolBar1, BorderLayout.EAST);
         getContentPane().add(jlblImage, BorderLayout.CENTER);
      }
      private class MyAction extends AbstractAction{
         String name;
     
         MyAction(String name, Icon icon){
            super(name,icon);
            putValue(Action.SHORT_DESCRIPTION, " Select this flag (" + name + ") to display it!");
            this.name = name;
         }
         public void actionPerformed(ActionEvent e) {
            if(name.equals("CANADA"))
               jlblImage.setIcon(caImageIcon);
            else if ( name.equals("UNITED STATES"))
               jlblImage.setIcon(usImageIcon);
         }
      }
      public static void main (String[]args){
         Actions applet = new Actions();
         JFrame frame = new JFrame();
         frame.setTitle("Flag Actions");
         frame.getContentPane().add(applet, BorderLayout.CENTER);
         applet.init();
         applet.start();
         frame.setSize(400,300);
         frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
         frame.setLocationRelativeTo(null);
         frame.setVisible(true);
      }
   }
// End Code. Huzzah!