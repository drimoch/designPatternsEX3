using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFacebookLogic;

namespace MyFacebookUI
{
    public partial class EditEventForm : Form
    {
        private IEvent m_eventToEdit;

        public event Action doneEditing;

        public EditEventForm(IEvent i_eventToEdit, Action done)
        {
            if (i_eventToEdit != null)
            {


                InitializeComponent();
                m_eventToEdit = i_eventToEdit;
                DateTime[] startDate;
                DateTime[] endDate;
                doneEditing += done;
                nameTextBox.Text = i_eventToEdit.Name;
                locationTextBox.Text = i_eventToEdit.Location;
                descriptionTextBox.Text = i_eventToEdit.Description;
                if (i_eventToEdit.StartTime != null)
                {
                    startDate = new DateTime[] { Convert.ToDateTime(i_eventToEdit.StartTime) };
                    startMonthCalendar.BoldedDates = startDate;
                }

                if (i_eventToEdit.EndTime != null)
                {
                    endDate = new DateTime[] { Convert.ToDateTime(i_eventToEdit.EndTime) };
                    endMonthCalender.BoldedDates = endDate;
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            eErrorType result = isFormValid();
            switch (result)
            {
                case eErrorType.OK:
                    m_eventToEdit.Name = nameTextBox.Text;
                    m_eventToEdit.Location = locationTextBox.Text;
                    m_eventToEdit.Description = descriptionTextBox.Text;
                    m_eventToEdit.StartTime = startMonthCalendar.SelectionStart;
                    m_eventToEdit.EndTime = endMonthCalender.SelectionStart;

                    this.Close();
                    break;
                case eErrorType.endSmallerThanStart:
                    MessageBox.Show("End date has to be after start date");
                    break;
                case eErrorType.emptyName:
                    MessageBox.Show("Name field is empty");
                    break;
                case eErrorType.emptyLocation:
                    MessageBox.Show("Location field is empty");
                    break;
                case eErrorType.emptyDescription:
                    MessageBox.Show("Description field is empty");
                    break;
            }
        }

        private eErrorType isFormValid()
        {
            eErrorType result = eErrorType.OK;
            if (string.IsNullOrEmpty(locationTextBox.Text))
            {
                result = eErrorType.emptyLocation;
            }

            if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                result = eErrorType.emptyDescription;
            }

            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                result = eErrorType.emptyName;
            }

            if (endMonthCalender.SelectionStart < startMonthCalendar.SelectionStart)
            {
                result = eErrorType.endSmallerThanStart;
            }

            return result;
        }

        public enum eErrorType
        {
            OK = 0,
            endSmallerThanStart = 1,
            emptyLocation = 2,
            emptyDescription = 3,
            emptyName = 4
        }
    }
}
