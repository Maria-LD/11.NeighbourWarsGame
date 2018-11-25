import java.util.Scanner;

public class NeighbourWarsGame {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        try {
            //input and checking data for Pesho
            System.out.print("Enter Pesho’s damage (0-100): ");
            int peshoDamage = Integer.parseInt(scanner.nextLine());
            while (peshoDamage < 0 || peshoDamage > 100) {
                System.out.print("Wrong number for Pesho's demage! It must be between 1 and 100: ");
                peshoDamage = Integer.parseInt(scanner.nextLine());
            }

            //input and checking data for Gosho
            System.out.print("Enter Gosho’s damage (0-100): ");
            int goshoDamage = Integer.parseInt(scanner.nextLine());
            while (goshoDamage < 0 || goshoDamage > 100) {
                System.out.print("Wrong number for Gosho's demage! It must be between 1 and 100: ");
                goshoDamage = Integer.parseInt(scanner.nextLine());
            }

            int peshoHealthPoints = 100;
            int goshoHealthPoints = 100;
            int turn = 1;

            while (true) {

                if (turn % 2 == 0) {                    //Gosho attacks
                    peshoHealthPoints -= goshoDamage;
                    if (peshoHealthPoints <= 0) {
                        break;
                    }
                    System.out.printf("Gosho used Thunderous fist and reduced Pesho to %d health.\n",
                            peshoHealthPoints);

                } else {                                //Pesho attacks
                    goshoHealthPoints -= peshoDamage;
                    if (goshoHealthPoints <= 0) {
                        break;
                    }
                    System.out.printf("Pesho used Roundhouse kick and reduced Gosho to %d health.\n",
                            goshoHealthPoints);
                }

                turn++;

                if ((turn - 1) % 3 == 0) {
                    peshoHealthPoints += 10;
                    goshoHealthPoints += 10;
                }

                if (peshoHealthPoints <= 0 || goshoHealthPoints <= 0) {
                    break;
                }

            }

            if (goshoHealthPoints > peshoHealthPoints) {
                System.out.printf("Gosho won in %dth round.", turn);
            } else {
                System.out.printf("Pesho won in %dth round.", turn);
            }

        } catch (Exception ex) {
            System.out.println("Invalid input! Start from the beginning!");
        }
    }
}