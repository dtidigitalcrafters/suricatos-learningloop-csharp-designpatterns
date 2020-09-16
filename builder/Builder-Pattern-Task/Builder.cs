using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

public interface ITaskReportBuilder {
  void BuildHeader ();
  void BuildBody ();
  void BuildFooter ();
}

public class TaskReportBuilder : ITaskReportBuilder {
  private List<Task> _tasks;
  private TaskReport _taskReport;

  public TaskReportBuilder() {
    _taskReport = new TaskReport();
    _tasks = new List<Task>();
  }

  public void AddTask(Task task) {
    _tasks.Add(task);
    _tasks.Sort(delegate(Task x, Task y)
        {
          return x.DueTo.CompareTo(y.DueTo);
        });
  }

  public TaskReport BuildReport() {
    BuildHeader();
    BuildBody();
    BuildFooter();

    return _taskReport;
  }

  public void BuildHeader() {
    _taskReport.Header = $"Você possui {_tasks.Count} tarefas.\n";
  }

  public void BuildBody() {
    CultureInfo ci = new CultureInfo("pt-BR");
    _taskReport.Body = string.Join(Environment.NewLine, _tasks.Select((t, i) => $"Tarefa {i+1}: {t.Title} - Deve ser entregue em: {t.DueTo.ToString(ci)}"));
  }

  public void BuildFooter() {
    _taskReport.Footer = $"\nDesejo sorte.";
  }
}