<!DOCTYPE html>
<html lang="en">
    <head>
        <title>PHP with HTML Forms</title>
        <meta charset="UTF-8">
    </head>
    <body>
        <h1>PHP with HTML Forms</h1>
        <!-- Check if num1 and num2 are valid numbers first -->
        <?php
            if (!is_numeric($_GET["num1"]) || !is_numeric($_GET["num2"]))
            {
                echo "<p>Both values must be numbers.</p>";
                echo "<a href=\"/\"><button>Try again</button></a>";
                echo "</body></html>";  // Close tags
                exit();
            }
        ?>
        <p>
            Here are the sum, difference, product, and quotient of the numbers
            you entered in the previous page.
        </p>
        <h3>Results</h3>
        <p>
            The input values are <strong><?php echo $_GET["num1"]; ?></strong>
            and <strong><?php echo $_GET["num2"]; ?></strong>.
        </p>
        <table border="1">
            <thead>
                <tr>
                    <th>Operation</th>
                    <th>Expression</th>
                    <th>Result</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>Sum</td>
                    <td><?php echo $_GET["num1"]; ?> + <?php echo $_GET["num2"]; ?></td>
                    <td><?php echo $_GET["num1"] + $_GET["num2"]; ?></td>
                </tr>
                <tr>
                    <td>Difference</td>
                    <td><?php echo $_GET["num1"]; ?> - <?php echo $_GET["num2"]; ?></td>
                    <td><?php echo $_GET["num1"] - $_GET["num2"]; ?></td>
                </tr>
                <tr>
                    <td>Product</td>
                    <td><?php echo $_GET["num1"]; ?> &times; <?php echo $_GET["num2"]; ?></td>
                    <td><?php echo $_GET["num1"] * $_GET["num2"]; ?></td>
                </tr>
                <tr>
                    <td>Quotient</td>
                    <td><?php echo $_GET["num1"]; ?> &divide; <?php echo $_GET["num2"]; ?></td>
                    <td><?php echo $_GET["num1"] / $_GET["num2"]; ?></td>
                </tr>
            </tbody>
        </table>
        <hr />
        <a href="/"><button>Ask for another calculation</button></a>
    </body>
</html>
