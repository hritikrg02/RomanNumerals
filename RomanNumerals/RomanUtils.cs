﻿namespace RomanNumerals; 

public static class RomanUtils {
    
    // outer index represents the decimal position (i.e. 10^index, e.g. 10^index 0 = units place)
    // inner index represents the actual digit (1 through 9, 0 is a null entry)
    // char is the actual letter for that number's roman representation
    private static readonly Dictionary<int, Dictionary<int, string>> RomanTable;

    static RomanUtils() {
        RomanTable = new Dictionary<int, Dictionary<int, string>>() {
            
            // units place
            { 0, new Dictionary<int, string>() {
                { 0, "null" }, // should never be used
                { 1, "I" },
                { 2, "II" },
                { 3, "III" },
                { 4, "IV" },
                { 5, "V" },
                { 6, "VI" },
                { 7, "VII" },
                { 8, "VIII"},
                { 9, "IX" }
            } },
            
            // tens place
            { 1, new Dictionary<int, string>() {
                { 0, "null" }, // should never be used
                { 1, "X" },
                { 2, "XX" },
                { 3, "XXX" },
                { 4, "XL" },
                { 5, "L" },
                { 6, "LX" },
                { 7, "LXX" },
                { 8, "LXXX"},
                { 9, "XC" }
            } },
            
            // hundreds place
            { 1, new Dictionary<int, string>() {
                { 0, "null" }, // should never be used
                { 1, "C" },
                { 2, "CC" },
                { 3, "CCC" },
                { 4, "CD" },
                { 5, "D" },
                { 6, "DC" },
                { 7, "DCC" },
                { 8, "DCCC"},
                { 9, "CM" }
            } },
            
            // thousands place
            { 1, new Dictionary<int, string>() {
                { 0, "null" }, // should never be used
                { 1, "M" },
                { 2, "MM" },
                { 3, "MMM" }
            } }
        };
    }

    // TODO description
    public static string ToRoman(this int num) {
        // TODO throw error if > 3999
        // TODO
        return "";
    }
}
