import java.util.List;
import java.util.Arrays;
import java.util.ArrayList;

class TestCase {
    public final int[] nums1;
    public final int m;
    public final int[] nums2;
    public final int n;

    public TestCase(int[] nums1, int m, int[] nums2, int n) {
        this.nums1 = nums1;
        this.m = m;
        this.nums2 = nums2;
        this.n = n;
    }
}

public class Solution {
    public static void merge(int[] nums1, int m, int[] nums2, int n) {
        int head = nums1.length - 1;
        m--;
        n--;
        while (head >= 0 && (m >= 0 || n >= 0)) {
            if (m < 0) {
                nums1[head--] = nums2[n--];
                continue;
            } else if (n < 0) {
                nums1[head--] = nums1[m--];
                continue;
            }

            if (nums1[m] < nums2[n]) {
                nums1[head--] = nums2[n--];
            } else {
                nums1[head--] = nums1[m--];
            }
        }
    }

    public static void main(String[] args) {
        List<TestCase> test_cases = new ArrayList<TestCase>() {
            {
                add(new TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3));
                add(new TestCase(new int[] { 1 }, 1, new int[] {}, 0));
                add(new TestCase(new int[] { 0 }, 0, new int[] { 1 }, 1));
                add(new TestCase(new int[] { 2, 0 }, 1, new int[] { 1 }, 1));
                add(new TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3));
                add(new TestCase(new int[] { 1, 4, 7, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3));
            }
        };

        for (int i = 0; i < test_cases.size(); i++) {
            Solution.merge(
                    test_cases.get(i).nums1,
                    test_cases.get(i).m,
                    test_cases.get(i).nums2,
                    test_cases.get(i).n);
            System.out.println(Arrays.toString(test_cases.get(i).nums1));
        }
    }
}
