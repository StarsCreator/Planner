using System;
using System.Collections.Generic;
using System.Data;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Services
{
    public interface ITableService
    {
        DataTable GetProjectTable(IEnumerable<Project> projects);
        DataTable GetReclamationTable(IEnumerable<Reclamation> reclamations);
    }

    public class TableService:ITableService
    {
        private string _temp="Состояние не известно";

        public DataTable GetProjectTable(IEnumerable<Project> projects)
        {
            var table = new DataTable();
            var idColumn = new DataColumn
                {
                    DataType = Type.GetType("System.Int32"),
                    ColumnName = "Id",
                };
                table.Columns.Add(idColumn);

                var nameColumn = new DataColumn
                {
                    DataType = Type.GetType("System.String"),
                    ColumnName = "Название"
                };
                table.Columns.Add(nameColumn);

                var startColumn = new DataColumn
                {
                    DataType = Type.GetType("System.DateTime"),
                    ColumnName = "Старт"
                };
                table.Columns.Add(startColumn);

                var finishColumn = new DataColumn
                {
                    DataType = Type.GetType("System.DateTime"),
                    ColumnName = "Окончание"
                };
                table.Columns.Add(finishColumn);

                var stateColumn = new DataColumn()
                {
                    DataType = Type.GetType("System.String"),
                    ColumnName = "Состояние"
                };
                table.Columns.Add(stateColumn);
            foreach (var proj in projects)
            {
                var row = table.NewRow();

                row["Id"] = proj.Id;
                row["Название"] = proj.Name;
                row["Старт"] = proj.Start;
                row["Окончание"] = proj.Finish;
                switch (proj.State)
                {
                    case 0:
                    {
                        _temp = "В очереди";
                        break;
                    }
                    case 1:
                    {
                        _temp = "В Работе";
                        break;
                    }
                    case 2:
                    {
                        _temp = "Закончен";
                        break;
                    }
                    case 3:
                    {
                        _temp = "Отпуск";
                        break;
                    }
                    case 4:
                    {
                        _temp = "На производстве";
                        break;
                    }
                    case 5:
                    {
                        _temp = "Приостановлен";
                        break;
                    }
                    case 6:
                    {
                        _temp = "Командировка";
                        break;
                    }
                }
                row["Состояние"] = _temp;
                table.Rows.Add(row);

            }
            return table;
        }

        public DataTable GetReclamationTable(IEnumerable<Reclamation> reclamations)
        {
            var table = new DataTable();
            var idColumn = new DataColumn
            {
                DataType = Type.GetType("System.Int32"),
                ColumnName = "Id",
            };
            table.Columns.Add(idColumn);

            var nameColumn = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Название"
            };
            table.Columns.Add(nameColumn);

            var startColumn = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                ColumnName = "Старт"
            };
            table.Columns.Add(startColumn);

            var finishColumn = new DataColumn
            {
                DataType = Type.GetType("System.DateTime"),
                ColumnName = "Окончание"
            };
            table.Columns.Add(finishColumn);

            var stateColumn = new DataColumn()
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Состояние"
            };
            table.Columns.Add(stateColumn);

            foreach (var rec in reclamations)
            {
                var row = table.NewRow();
                row["Id"] = rec.Id;
                row["Название"] = rec.ReclamationAct;
                row["Старт"] = rec.Start;
                row["Окончание"] = rec.Finish;
                switch (rec.State)
                {
                    case 0:
                        {
                            _temp = "Заявлено";
                            break;
                        }
                    case 1:
                        {
                            _temp = "В Работе";
                            break;
                        }
                    case 2:
                    {
                        _temp = "Выполнено";
                            break;
                        }
                }
                row["Состояние"] = _temp;
                table.Rows.Add(row);

            }
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