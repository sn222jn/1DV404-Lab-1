using System;
using System.Linq;
using System.Collections.Generic;

public struct Point { 
  public int x, y;
  
  public Point(int a, int b) {
    x = a;
    y = b;
  }
}

public class Triangle {
  double[] sides;

  public Triangle(double a, double b, double c) {
    sides = new double[] { a, b, c };
  } 

  public Triangle(double[] s) {
    sides = new double[s.Length];
    for(int i=0;i<s.Length;i++)
      sides[i]=s[i];
  } 

  public Triangle(Point a, Point b, Point c) {
    sides = new double[3];
    sides[0] = Math.Sqrt(Math.Pow((double)(b.x - a.x), 2.0) + Math.Pow((double)(b.y - a.y), 2.0));
    sides[1] = Math.Sqrt(Math.Pow((double)(b.x - c.x), 2.0) + Math.Pow((double)(b.x - a.x), 2.0));
    sides[2] = Math.Sqrt(Math.Pow((double)(c.x - a.x), 2.0) + Math.Pow((double)(c.x - a.x), 2.0));
  }

  public Triangle(Point[] s) {
    sides = new double[s.Length];
    sides[0] = Math.Sqrt(Math.Pow((double)(s[1].x - s[0].x), 2.0) + Math.Pow((double)(s[1].y - s[0].y), 2.0));
    sides[1] = Math.Sqrt(Math.Pow((double)(s[1].x - s[2].x), 2.0) + Math.Pow((double)(s[1].x - s[0].x), 2.0)); // Changed last [] from 2 to 1.
    sides[2] = Math.Sqrt(Math.Pow((double)(s[2].x - s[0].x), 2.0) + Math.Pow((double)(s[2].x - s[0].x), 2.0));
  }

  private int uniqueSides() {
    return sides.Distinct<double>().Count();
  }

  public bool isScalene() {
    if(uniqueSides()==3) // Changed from 1 to 3
      return true;
    return false;
  }

  public bool isEquilateral() {
    if(uniqueSides()==1) // Changed from 3 to 1
      return true;
    return false;
  }

  public bool isIsosceles() {
    if(uniqueSides()==2)
      return true;
    return false;
  }
}


