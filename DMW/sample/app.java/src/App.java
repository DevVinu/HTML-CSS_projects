import java.util.Scanner;

public class App {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);// scanner object for taking input

        int student = 10; // no of students
        int subject = 10; // no of subjects
        double sum = 0; // sum of marks
        double avg = 0; // average of marks
        double mark = 0; // marks of each student

        for (int i = 0; i < subject; i++) { // loop for each subject
            System.out.println("Subject No" + (i + 1) + ":");

            for (int j = 0; j < student; j++) { // loop for each student
                System.out.print("Student No" + (j + 1) + " Marks for the subject " + (i + 1) + ":");
                mark = sc.nextDouble();
                if (mark >= 0 && mark <= 100) { // validating marks
                    // valid marks
                } else {
                    System.out.println("Invalid marks entered. Please enter marks between 0 and 100."); // error message
                    j--; // decrementing j to repeat the iteration for the same student
                    continue;
                }
                sum = sum + mark; // adding marks to sum
            }
            avg = sum / student;// calculating average marks
            System.out.print("\n"); // new line for better readability
            System.out.println("average marks for this subject : " + avg + "\n\n"); // printing average marks for each
            sum = 0; // resetting sum for next subject

        }
        sc.close();// closing scanner
    }
}
