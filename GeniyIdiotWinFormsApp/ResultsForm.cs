﻿using GeniyIdiot.Common;
namespace GeniyIdiotWinFormsApp;
public partial class ResultsForm : Form
{
    public ResultsForm()
    {
        InitializeComponent();
    }

    private void ResultsForm_Load(object sender, EventArgs e)
    {
        var results = UserResultStorage.GetUserResults();
        foreach (var result in results)
        {
            resultsDataGridView.Rows.Add(result.Name, result.RightAnswersCount, result.Diagnoses);
        }
        Hide();
    }
}



