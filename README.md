# FirstBankSuncoast

PEDAC FirstBankSuncoast

DisplayGreeting()
PromptForString()
PromptForInteger()

Menu()
[D]eposit (checking or savings)
[W]ithdraw (checking or savings)
[V]iew transaction history
[B]alance Statement (checking or savings)
[Q]uit

Create class Transaction (properties: Amount, Type, Account)
Creat list to store transaction history
Methods (behaviors):
-Deposit & Withdraw
-SavingTransactions (StreamWriter)
-LoadTransactions (StreamReader)

If user selects Deposit > Checking
-Prompt: Amount (promptForInteger)
-Add to checking history
-Update balance
If user selects Deposit > Savings
-Prompt: Amount (promptForInteger)
-Add to checking history
-Update balance

If user selects Withdraw > Checking
-Prompt: Amount (promptForInteger)
-Add amount to checking history
-Update balance
-if amount would make balance < 0 : Error message, insufficient funds

If user selects Withdraw > Savings
-Prompt: Amount (promptForInteger)
-Add amount to savings history
-Update balance
-if amount would make balance < 0 : Error message, insufficient funds
