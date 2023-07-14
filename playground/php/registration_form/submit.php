<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Registration Form</title>
        <meta charset="UTF-8">
        <link rel="stylesheet" href="style.css">
    </head>
    <body>
        <header>
            <h1>Registration Form</h1>
        </header>
        <main>
            <h3>Thank you for your registration!</h3>
            <p>We received the following information:</p>
            <ul>
                <?php
                    /*
                     * Sanitize user input using `strip_tags()` function
                     * to prevent XSS and/or CSRF attacks.
                     */
                    echo "<li><b>Name</b>: " . strip_tags($_POST["name"]) . "</li>";
                    echo "<li><b>Birthday</b>: " . strip_tags($_POST["birthday"]) . "</li>";
                    echo "<li><b>Gender</b>: " . strip_tags($_POST["gender"]) . "</li>";
                    echo "<li><b>School</b>: " . strip_tags($_POST["school"]) . "</li>";
                    echo "<li><b>Course</b>: " . strip_tags($_POST["course"]) . "</li>";
                    echo "<li><b>Family Background</b>: " . strip_tags($_POST["fam-bg-textarea"]) . "</li>";
                ?>
            </ul>
        </main>
    </body>
</html>
