public class JNIJavaHowTo {
  public static void main(String[] args) {
    JavaHowTo jht = new JavaHowTo();
    // clear the screen
    jht.cls();
    // set the cursor at line 10 column 20
    jht.setCursorPosition((short)20,(short)10);
    System.out.print("Real's HowTo");
    // set the cursor at line 15 column 20
    jht.setCursorPosition((short)20,(short)15);
    jht.keepColors();
    jht.setColor(jht.FOREGROUND_WHITE,jht.BACKGROUND_BLUE);
    System.out.print("http://www.rgagnon.com");
    jht.restoreColors();
    // set the cursor at line 20 column 0
    jht.setCursorPosition((short)0,(short)20);
    }
}