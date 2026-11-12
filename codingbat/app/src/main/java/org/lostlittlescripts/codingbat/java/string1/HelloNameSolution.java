/**
 * Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!".
 *
 * helloName("Bob") → "Hello Bob!"
 * helloName("Alice") → "Hello Alice!"
 * helloName("X") → "Hello X!"
 */

package org.lostlittlescripts.codingbat.java.string1;

public class HelloNameSolution {
    public String helloName(String name) {
        return String.format("Hello %s!", name);
    }
}
