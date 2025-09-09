public class Types {
    public enum F1Track {
        MONZA,
        SPA,
        MONTECARLO
    }

    public static int number = 1234;
    public static float decimal = 3.14523f;
    public static boolean bool = true;
    public static char character = 'C';

    public static void main(String[] args) {
        F1Track track = F1Track.MONZA;
        System.out.println("Track: " + track);
        System.out.println("int: " + number);
        System.out.println("float: " + decimal);
        System.out.println("boolean: " + bool);
        System.out.println("char: " + character);
    }
}