using System;

class MainClass {
  public static void Main (string[] args) {
    Task task1 = new Task {
      Title = "Criar um projeto com o pattern Builder",
      DueTo = new DateTime(2020, 9, 2, 23, 59, 59)
      };

    Task task2 = new Task {
      Title = "Surtar",
      DueTo = new DateTime(2020, 9, 7, 11, 18, 0)
      };

    Task task3= new Task {
      Title = "Alimentar os passarinhos",
      DueTo = new DateTime(2020, 9, 1, 20, 35, 5)
      };

    TaskReportBuilder builder = new TaskReportBuilder();
    builder.AddTask(task1);
    builder.AddTask(task2);
    builder.AddTask(task3);

    TaskReport report = builder.BuildReport();
    Console.WriteLine(report.GetReportAsString()); 
  }
}