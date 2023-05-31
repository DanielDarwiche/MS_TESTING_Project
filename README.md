# MsTesting the group project KiwiBanken
## Description
KiwiBankomaten is an object oriented C# program made to function as a digital bank, as a school group project.
Testing the application with MsTest is the focus.

## 1. Planning the tests - Analyzing what could go wrong and what to test.

### TestClass: Checking loan limit for a Customer - *CheckLoanLimit();*	 
### What can go wrong and should be tested? The following will be TestMethods.
- Foreign currency not being converted to SEK. Converting wrong currency should result in failed test and converting valid currency should result in passed test.
- Failing in identifying (amount of money)currency as SEK. Not identifying(an amount of money) as SEK or foreign currency should result in failed test.
- Method converting the wrong max loan amount, based on Customers previous loans. Calculating the correct max loan amount should result in passed test. 
- Method converting the wrong max loan amount, based on Customers NOT having any previous loans. Calculating the correct max loan amount should result in passed test. 

### TestClass: Convering amount of money to SEK - *Method ConvertToSek();*	
### What can go wrong and should be tested? The following will be TestMethods.
- Converting valid currency to SEK but calculating wrong currency value. Wrong currency value should result in failed test. 
- Converting to SEK from an invalid currency. Invalid currency returning 0 should result in passed test.

### TestClass: Saving data in database as program runs - *Method CheckIfAccountExists();*
### What can go wrong and should be tested? The following will be TestMethods.
- Account nummer existing and not being found. Finding an account when accountnumber does exist should pass test.
- Account nummer not existing and being found. Finding an account when accountnumber does NOT exist should fail test.
