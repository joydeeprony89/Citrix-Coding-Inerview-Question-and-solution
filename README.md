# Citrix-Coding-Inerview-Question-and-solution

A programmer string contains letters that can be rearranged to form the word 'programmer' and is a substring of a longer string. Note that the strings 'programmer', 'grammproer', and 'prozmerqgram' are all classified as programmer strings by this definition. Given a string, determine the number of indices that lie between the rightmost and leftmost programmer strings that it contains.

 

Example

s = 'programmerxxxprozmerqgram'



In this example, indices 0 - 9 form one programmer string and indices 13 - 24 contain another. There are 3 indices between the programmer, so the function will return 3.

 

Function Description

Complete the function programmerStrings in the editor below.

 

programmerStrings has the following parameter(s):

    string s:  a string containing 2 programmer strings

 

Returns:

    int: the number of indices which are between the rightmost and leftmost programmer strings within s

 

Constraints

String s consists of lowercase English alphabetic letters only, ascii[a-z].
1 ≤ the length of s ≤ 105.
There will always be two non-overlapping programmer strings.
 

Input Format for Custom Testing
Sample Case 0
Sample Input

STDIN                           Function
-----                           ------
progxrammerrxproxgrammer   →    s = 'progxrammerrxproxgrammer'
 

Sample Output

2
 

Explanation

There are two indices, i = 11 and i = 12 between the leftmost and rightmost programmer strings.
progxrammerrxproxgrammer
 

Sample Case 1
Sample Input

STDIN                               Function
-----                               -----
xprogxrmaxemrppprmmograeiruu   →    s = 'xprogxrmaxemrppprmmograeiruu'
 

Sample Output

2
 

Explanation

There are two indices, i = 13 and i = 14, between the leftmost and rightmost programmer strings.
xprogxrmaxemrppprmmograeiruu
 

Sample Case 2
Sample Input

STDIN                       Function
-----                       -----
programmerprogrammer   →    s = 'programmerprogrammer'
 

Sample Output

0
 

Explanation

There are no indices between the leftmost and rightmost programmer strings.
xprogxrmaxemrppprmmograeiruu
