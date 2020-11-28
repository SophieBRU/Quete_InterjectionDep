# Quete_InterjectionDep

# Challenge
A partir de l'exemple précédent, injecte une classe QuarterlySalaryCalculator injectée en tant que ISalaryCalculator par ASP.Net. La classe QuarterlySalaryCalculator transforme un salaire annuel en salaire trimestriel.

# Critères de validation
Les fichiers Controllers/SalaryController.cs, Services/MonthlySalaryCalculator.cs, Services/ISalaryCalculator.cs et Startup.cs sont présents à l'identique dans la solution
Un fichier Services/QuarterlySalaryCalculator.cs définit une classe implémentant l'interface ISalaryCalculator
L'implémentation de la méthode CalculateSalary de la classe QuarterlySalaryCalculator transforme un salaire annuel en salaire trimestriel
Dans le fichier Startup.cs, un appel à la méthode AddScoped injecte QuarterlySalaryCalculator en tant que ISalaryCalculator
La route Api/Salary/{montantAnnuel} retourne un salaire trimestriel
