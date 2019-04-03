using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenSportSchool
{
    /// <summary>
    /// Ученик
    /// </summary>
    public class Children
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Bithday { get; set; }
        /// <summary>
        ///  Имя родителя
        /// </summary>
        public string ParentName { get; set; }
        /// <summary>
        /// Фотография
        /// </summary>
        public byte[] Photo { get; set; }
    }

    /// <summary>
    /// Преподаватель
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string NameTeacher { get; set; }
        /// <summary>
        ///  Направление
        /// </summary>
        public SportType sportType { get; set; }
        /// <summary>
        /// Фотография
        /// </summary>
        public byte[] Photo { get; set; }
    }

    /// <summary>
    /// Занятия
    /// </summary>
    public class Lessons
    {
        /// <summary>
        /// Направление
        /// </summary>
        public SportType sportType { get; set; }
        /// <summary>
        /// День недели
        /// </summary>
        public DayOfWeek dayOfWeek { get; set; }
        /// <summary>
        /// Время
        /// </summary>
        public TimeSpan Time { get; set; }
        /// <summary>
        /// Место проведения
        /// </summary>
        public string Place { get; set; }

        public override string ToString()
        {
            return $"Направление: {sportType}, День недели: {dayOfWeek}, Время: {Time}, Место проведения: {Place}";
        }
    }

    /// <summary>
    /// Тип направления
    /// </summary>
    public enum SportType
    {
        /// <summary>
        /// Баскетбол
        /// </summary>
        Basketball,
        /// <summary>
        /// Футбол
        /// </summary>
        Football,
        /// <summary>
        /// Плавание
        /// </summary>
        Swimming,
        /// <summary>
        /// Художественная гимнастика
        /// </summary>
        Gymnastics,
        /// <summary>
        /// Легкая атлетика
        /// </summary>
        Athletics,
        /// <summary>
        /// Бадминтон
        /// </summary>
        Badminton,
        /// <summary>
        /// Водное поло
        /// </summary>
        Polo,
        /// <summary>
        /// Гребля
        /// </summary>
        Rowing,
        /// <summary>
        /// Подводное плавание
        /// </summary>
        Diving,
        /// <summary>
        /// Современные танцы
        /// </summary>
        Dance,
        /// <summary>
        /// Чирлидинг
        /// </summary>
        Cheerliding,
    }

