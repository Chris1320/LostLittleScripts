package org.lostlittlescripts.codingbat.java.string1;

import org.junit.Assert;
import org.junit.Test;

public class MakeTagsSolutionTest {
    @Test
    public void testMakeTagsSolution() {
        MakeTagsSolution solution = new MakeTagsSolution();

        Assert.assertEquals("<i>Yay</i>", solution.makeTags("i", "Yay"));
        Assert.assertEquals("<i>Hello</i>", solution.makeTags("i", "Hello"));
        Assert.assertEquals("<cite>Yay</cite>", solution.makeTags("cite", "Yay"));
        Assert.assertEquals("<address>here</address>", solution.makeTags("address", "here"));
        Assert.assertEquals("<body>Heart</body>", solution.makeTags("body", "Heart"));
        Assert.assertEquals("<i>i</i>", solution.makeTags("i", "i"));
        Assert.assertEquals("<i></i>", solution.makeTags("i", ""));
    }
}
