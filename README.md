# MsTesting the group project KiwiBanken
## Description
KiwiBankomaten is an object oriented C# program made to function as a digital bank, as a school group project.
Testing the application with MsTest is the focus.

## 1. Planning the tests - Analyzing what could go wrong and what to test.

### TestClass: Loaning money in customer account - *Method LoanMoney();*	[Menu choice #6] 
### What can go wrong and should be tested? The following will be TestMethods.
- Submitting wrong input to choose loan account. Not entering 1, 2 or 3. 
Choosing a negative number, 0, a string or bigger than 3 should be wrong input.
- Not choosing J/N to confirm choice. Choosing another letter, numbers or multiple letters should be wrong input.
- Entering a faulty amount of money to insert. Negative numbers or a string should be wrong input.

### TestClass: Inserting money into a new customer account - *Method InsertMoneyIntoNewAccount();*	[Menu choice #4]
### What can go wrong and should be tested? The following will be TestMethods.
- Submitting wrong input to choose account. Not entering 1, 2, 3 or 4. Choosing 0, more than 5 or a string should be wrong input.
- Not choosing J/N for confirmation. Choosing another letter, numbers or multiple letters should be wrong input.
(Function appears multiple times)
- Submitting faulty name for account created. Entering name containing no signs or only spaces whould be wrong input.
 (Before testing, entering spaces only is accepted!)
- Choosing wrong currency for the account. Not entering correct letters as input(non caps-sensitive) should be wrong input.
- Entering faulty amount of money in account. Entering empty, spaces, negative numbers, above datatype-limit or 0 should be wrong input.
(Before testing, entering spaces, empty, negative or above datatype-limit is catched!)

### TestClass: Saving data in database as program runs - *Method LoadDataBase();*
### What can go wrong and should be tested? The following will be TestMethods.
- That the files in database list of files are not found. The files not being found should result in failed test.
- That the files in database list of files are not read. The files not being read should result in failed test.
- StreamReader not reading file in database. The file not being read should result in failed test.
- StreamReader not closing as instructed. StreamReader not closing should result in failed test.
- Not succesfully updating database. Not updating database should result in failed test.
- Not succesfully using function to create files in database. Not using the function succesfully should result in failed test.
