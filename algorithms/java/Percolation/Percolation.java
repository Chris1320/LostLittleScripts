/*
 * Percolation
 * Given a composite systems comprised of randomly distributed insulating and metallic
 * materials: what fraction of the materials need to be metallic so that the composite system
 * is an electrical conductor? Given a porous landscape with water on the surface (or oil
 * below), under what conditions will the water be able to drain through to the bottom (or
 * the oil to gush through to the surface)? Scientists have defined an abstract process known
 * as percolation to model such situations.
 *
 */

import java.util.Scanner;

import edu.princeton.cs.algs4.StdRandom;
import edu.princeton.cs.algs4.StdStats;
import edu.princeton.cs.algs4.StdRandom;
import edu.princeton.cs.algs4.WeightedQuickUnionUF;


public class Percolation
{
    int[] id;  // Initialize an array of integers.
    int[] size;  // Size of each tree.
    int size_per_row;  // The grid size.
    boolean[] id_state;  // True if the site at grid (x,y) is open.

    // creates n-by-n grid, with all sites initially blocked
    public Percolation(int n)
    {
        int total = (n * n) + 2;  // Create an n-by-n grid and add two as the top and bottom roots.
        id = new int[total];
        size = new int[total];
        for (int i = 0; i < size.length; i++) size[i] = 1;  // Set default tree size.
        size_per_row = n;
    }

    public int coordsToId(int row, int col)
    // Convert coordinates to array index.
    {
        return ((row * size_per_row) - 1) + (col - 1);
    }

    private int getRoot(int x)
    // Get the root of x.
    {
        while (x != id[x]) x = id[x];
        return x;
    }

    private void union(int p, int q)
    {
        if (size[p] > size[q])
        {
            id[getRoot(q)] = getRoot(p);
            size[getRoot(p)] += size[getRoot(q)];
        }
        else if (size[p] < size[q])
        {
            id[getRoot(p)] = getRoot(q);
            size[getRoot(q)] += size[getRoot(p)];
        }
        else
        {
            id[getRoot(p)] = getRoot(q);
            size[getRoot(q)] += size[getRoot(p)];
        }
    }

    private boolean connected(int p, int q)
    {
        return id[p] == id[q];
    }

    // opens the site (row, col) if it is not open already
    public void open(int row, int col)
    {
        id_state[coordsToId(row, col)] = true;
    }

    // is the site (row, col) open?
    public boolean isOpen(int row, int col)
    {
        return id_state[coordsToId(row, col)];
    }

    // is the site (row, col) full?
    public boolean isFull(int row, int col)
    {
        return connected(0, coordsToId(row, col));
    }

    // returns the number of open sites
    public int numberOfOpenSites()
    {
        int result = 0;
        for (int i = 0; i < id_state.length; i++)
        {
            if (id_state[i]) result++;
        }
        return result;
    }

    // does the system percolate?
    public boolean percolates()
    {
        return connected(0, id.length);
    }

    // test client (optional)
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter grid size: ");
        int grid_size = input.nextInt();
        System.out.println("Creating a " + grid_size + " by " + grid_size + " grid...");
        Percolation percolation = new Percolation(grid_size);
        while (true)
        {
            System.out.println("Open sites: " + percolation.numberOfOpenSites());
            System.out.println("System Percolation: " + percolation.percolates() + '\n');
            System.out.println("Opening grid " + x + ", " + y + "...");
        }
    }
}
