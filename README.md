# FlyingWithAKiwi

The code should build with no problems

Some Pascal Triangle tests trigger stack overflow exception that was not yet handled.


1. Lost about 30 minutes by trying to do in in Java, and decided not to 😃 it went to slow. 
After I decided to do it in c#, sorry for that.

2. In the webdriver test:
a.) Login using invalid credentials and Validate unsuccessful login is the same from my perspective, at least it should be, (typo -> unsuccessfull is with 1 L) 
the same is with Logout and validate successful logout (typo -> succesfull with 2 S and 1 L) 
If you disagree, we can discuss it further face2face
b.) Don’t know what “reccomented”  at point 4 really means. I suppose it is “recommended” and I included the test case (but not a best practice to implement something based on a hunch)
 
3. The Pascal Triangle tests PascalPositiveTest(3,4,6) and (5,4,1) throws a StackOverflowException that I did not had the time to debug.

4. Just to bring a litle bit of clarity into the Algorithms tests: Algorithms are not my strong point, and for me it would take much longer than 4 hours to figure out by myself how to solve these.
   So, to understand it faster, I used the help of my best fried google and implemented some changes in the code so that it suites my needs.
