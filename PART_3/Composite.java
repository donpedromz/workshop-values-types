package PART_3;
import java.util.List;
import java.util.Map;
import java.util.ArrayList;
import java.util.HashMap;
public class Composite {
    public static class Car{
        String engine;
        String tyres;
        public Car(String engine, String tyres){
            this.engine = engine;
            this.tyres = tyres;
        }
        @Override
        public String toString(){
            return "Engine: " + this.engine + "," +
            "Tyres: " + this.tyres;
        }
    }
    public static void main(String[] args) {
        List<String> names = new ArrayList<>();
        names.add("Pablo");
        names.add("Luisa");
        names.add("Castri");
        names.add("Sebas");
        names.add("Daniel");
        names.forEach(name ->{
            System.out.println(name);
        });
        //Class
        Car rb19 = new Car("Honda", "Pirelli P Zero C4");
        System.out.println(rb19);
        // Maps
        Map<String, Float> grades = new HashMap<>();
        grades.put("Pablo", 3.5f);
        grades.put("Luisa", 5f);
        grades.put("Castri", 4.8f);
        grades.put("Sebas", 4.8f);
        grades.put("Dani", 4.81f);
        for(String key : grades.keySet()){
            System.out.println(key + "," + grades.get(key));
        }
    }
}
