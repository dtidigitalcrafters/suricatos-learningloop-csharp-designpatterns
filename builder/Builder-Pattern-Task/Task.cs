using System;
using System.Text;

public class Task {
  public string Title { get; set; }
  public DateTime DueTo { get; set; }
}

public class TaskReport {
  public string Header { get; set; }
  public string Body { get; set; }
  public string Footer { get; set; }

  public string GetReportAsString() =>
        new StringBuilder()
        .AppendLine(Header)
        .AppendLine(Body)
        .AppendLine(Footer)
        .ToString();
}