package sample;
import java.util.Scanner;


public class SimpleAverage {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int NUM_STUDENTS = 100;
        int NUM_SUBJECTS = 10;

        double totalClassMarks = 0; // total marks of all students

        for (int i = 0; i < NUM_STUDENTS; i++) {
            System.out.println("Student " + (i + 1));
            double sum = 0;

            for (int j = 0; j < NUM_SUBJECTS; j++) {
                System.out.print("Enter mark for subject " + (j + 1) + ": ");
                double mark = sc.nextDouble();
                sum += mark;
            }

            double studentAverage = sum / NUM_SUBJECTS;
            totalClassMarks += sum;

            System.out.println("Average for Student " + (i + 1) + ": " + studentAverage);
            System.out.println();
        }

        double classAverage = totalClassMarks / (NUM_STUDENTS * NUM_SUBJECTS);

        System.out.println("Overall Class Average: " + classAverage);

        sc.close();
    }
}
