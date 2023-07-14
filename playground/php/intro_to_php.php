<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Activity 13: Introduction to PHP</title>
        <meta charset="utf-8">
    </head>
    <body>
        <?php
            /*
             * Activity 13.1:
             * 
             * Display your name, address, course, and year
             * level in paragraph format.
             */
            $name = "Chris";  // String datatypes
            $address = "the Philippines";
            $course = "BS Computer Science";
            $yearlvl = 1;  // Integer datatype

            // Concatenate strings using the `.` operator.
            echo "<p>I am "
                . $name
                . " from "
                . $address
                . ". I am studying year "
                . $yearlvl
                . " of "
                . $course
                . ".</p>\n";
        ?>
        <hr/>
        <?php
            /*
             * Activity 13.2:
             * 
             * Display the greeting with your name and course in the upper
             * left corner of the page.
             */
            $greeting = "Good day, I am learning my PHP script.";
            echo "<p>" . $greeting . "</p>\n";
        ?>
        <hr/>
        <ul>
            <?php
                /*
                * Activity 13.3:
                * 
                * Display the sum, difference, product, and quotient of the
                * 4 variables with proper label.
                */
                $a = 5;
                $b = 4;
                $c = 10;
                $d = 20;

                echo "<li>Sum: "
                    . $a + $b + $c + $d . "</li>\n";  // Output: 39
                echo "\t\t\t<li>Difference: "
                    . $a - $b - $c - $d . "</li>\n";  // Output: -29
                echo "\t\t\t<li>Product: "
                    . $a * $b * $c * $d . "</li>\n";  // Output: 4,000
                echo "\t\t\t<li>Quotient: "
                    . $a / $b / $c / $d . "</li>\n";  // Output: 0.00625
            ?>
        </ul>
    </body>
</html>
