using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Services
{
    public interface IChartService
    {
        DataTable GetTable(List<Project> projects, User user);
        DataTable GetTable(List<Project> projects);
    }

    public class ChartService : IChartService
    {
        private int _temp;
        public DataTable GetTable(List<Project> projects,User user)
        {
            DataTable table = new DataTable();
            DataColumn stateColumn = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "State"
            };
            DataColumn valueColumn = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Value",
            };
            table.Columns.Add(stateColumn);
            table.Columns.Add(valueColumn);

            var row = table.NewRow();

            _temp = (from pr in projects
                    where pr.UserId == user.Id
                    where pr.State == 0
                    select pr).Count();

            row["State"] = "В очереди";
            row["Value"] = _temp;

            table.Rows.Add(row);

            var row1 = table.NewRow();

            _temp = (from pr in projects
                    where pr.UserId == user.Id
                    where pr.State == 1
                    select pr).Count();

            row1["State"] = "В работе";
            row1["Value"] = _temp;

            table.Rows.Add(row1);

            var row2 = table.NewRow();

            _temp = (from pr in projects
                    where pr.UserId == user.Id
                    where pr.State == 2
                    select pr).Count();

            row2["State"] = "Закончен";
            row2["Value"] = _temp;

            table.Rows.Add(row2);

            var row3 = table.NewRow();

            _temp = (from pr in projects
                    where pr.UserId == user.Id
                    where pr.State == 5
                    select pr).Count();

            row3["State"] = "Приостановлен";
            row3["Value"] = _temp;

            table.Rows.Add(row3);

            return table;

        }
        public DataTable GetTable(List<Project> projects)
        {
            DataTable table = new DataTable();
            DataColumn stateColumn = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "State"
            };
            DataColumn valueColumn = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Value",
            };
            table.Columns.Add(stateColumn);
            table.Columns.Add(valueColumn);

            var row = table.NewRow();

            _temp = (from pr in projects
                     where pr.State == 0
                     select pr).Count();

            row["State"] = "В очереди";
            row["Value"] = _temp;

            table.Rows.Add(row);

            var row1 = table.NewRow();

            _temp = (from pr in projects
                     where pr.State == 1
                     select pr).Count();

            row1["State"] = "В работе";
            row1["Value"] = _temp;

            table.Rows.Add(row1);

            var row2 = table.NewRow();

            _temp = (from pr in projects
                     where pr.State == 2
                     select pr).Count();

            row2["State"] = "Закончен";
            row2["Value"] = _temp;

            table.Rows.Add(row2);

            var row3 = table.NewRow();

            _temp = (from pr in projects
                     where pr.State == 5
                     select pr).Count();

            row3["State"] = "Приостановлен";
            row3["Value"] = _temp;

            table.Rows.Add(row3);

            return table;
        }
    }
}
/*
В очереди
В работе
Закончен
Отпуск
На производстве
Приостановлен
Командировка
 */