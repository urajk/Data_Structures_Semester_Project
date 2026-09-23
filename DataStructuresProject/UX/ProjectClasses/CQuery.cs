using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject.UX.ProjectClasses
{
    public class CQuery
    {
        //----------------------------------------------------------------------
        private int _id;
        public int Id { get { return _id; } }
        //----------------------------------------------------------------------
        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; } }
        //----------------------------------------------------------------------
        private string _text;
        public string Text { get { return _text; } set { _text = value; } }
        //----------------------------------------------------------------------
        private static int _count = 001;
        //----------------------------------------------------------------------
        public CQuery(string p_sText) 
        {
            this._id = _count;
            this.Date = DateTime.Now;
            this.Text = p_sText;

            _count++;
        }
        //----------------------------------------------------------------------
        public override string ToString() 
        {
            return $"# {this._id} {this.Date} Text: {this.Text}";
        }
        //----------------------------------------------------------------------
    }
}
