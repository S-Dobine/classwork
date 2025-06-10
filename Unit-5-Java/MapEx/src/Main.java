import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.TreeMap;
import java.util.Map;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {{

        //Map<String, Integer> peoplesNumbers = new HashMap<>(); // random order
        Map<String, Integer> peoplesNumbers = new TreeMap<>(); // alphabetical order
        //Map<String, Integer> peoplesNumbers = new LinkedHashMap<>(); // entered in order

        peoplesNumbers.put("Frank", 42);
        peoplesNumbers.put("Ravyn", 5);
        peoplesNumbers.put("Missy", 13);
        peoplesNumbers.put("Youssef", 7);
        peoplesNumbers.put("Zach", 51);

        System.out.println("Ravyn's favorite number is " + peoplesNumbers.get("Ravyn"));

        for (Map.Entry<String, Integer> anEntry : peoplesNumbers.entrySet());

        }
    }
}