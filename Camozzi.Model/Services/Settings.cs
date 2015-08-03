using System;

namespace Camozzi.Model.Services
{
    public interface ISettings
    {
        string LastUser { get; set; }
        DateTime AllProjectStart { get; set; }
        DateTime SelfProjectStart { get; set; }
        int AllProjectDuration { get; set; }
        int SelfProjectDuration { get; set; }
        int SynchronizeTime { get; set; }
        bool HideEndProject { get; set; }
        bool AddManagerName { get; set; }

        void Save();
    }

    public class Settings : ISettings
    {
        public string LastUser
        {
            get { return UserSettings.Default.Lastuser; }
            set { UserSettings.Default.Lastuser = value; }
        }

        public DateTime AllProjectStart
        {
            get { return UserSettings.Default.AllProjectsStart; }
            set { UserSettings.Default.AllProjectsStart = value; }
        }

        public DateTime SelfProjectStart
        {
            get { return UserSettings.Default.SelfProjectsStart; }
            set { UserSettings.Default.SelfProjectsStart = value; }
        }

        public int AllProjectDuration
        {
            get { return UserSettings.Default.AllProjectsDuration; }
            set { UserSettings.Default.AllProjectsDuration = value; }
        }

        public int SelfProjectDuration
        {
            get { return UserSettings.Default.SelfProjectsDuration; }
            set { UserSettings.Default.SelfProjectsDuration = value; }
        }

        public int SynchronizeTime
        {
            get { return UserSettings.Default.SynchronizeTime; }
            set { UserSettings.Default.SynchronizeTime = value; }
        }

        public bool HideEndProject
        {
            get { return UserSettings.Default.HideEndProject; }
            set { UserSettings.Default.HideEndProject = value; }
        }

        public bool AddManagerName
        {
            get { return UserSettings.Default.AddManagerName; }
            set { UserSettings.Default.AddManagerName = value; }
        }

        public void Save()
        {
            UserSettings.Default.Save();
        }
    }
}