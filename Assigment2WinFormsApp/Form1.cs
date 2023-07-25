using Assigment2WinFormsApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net.Mail;
using System.Windows.Forms;
using static Assigment2WinFormsApp.ValidationHelper;

// Student Name: Muhammad Elsoukkary
// Created: July 14, 2023

namespace Assigment2WinFormsApp
{
    public partial class Form1 : Form
    {
        private const string path = @"..\..\..\..\appointments.txt";

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the pre-fill button click
        private void btnPreFill_Click(object sender, EventArgs e)
        {
            // Prefill some fields with default values
            txtCustomerName.Text = "John Doe";
            txtCity.Text = "Waterloo";
            txtCellPhone.Text = "226-581-3345";
            txtYear.Text = "2023";
            txtEmail.Text = "muhammadels2323@gmail.com";
            txtMakeAndModel.Text = "Honda Pilot";
            txtProvinceCode.Text = "ON";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessages.Text = "";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // Initialize a list to store any errors that occur during validation
            List<string> errors = new List<string>();
            string appointmentInfo = ""; // To store the appointment information

            // Extract data from text boxes
            string address = txtAddress.Text;
            string postalcode = txtPostalCode.Text;
            string cellPhone = txtCellPhone.Text;
            string provinceCode = txtProvinceCode.Text;
            string city = txtCity.Text;
            string makeAndModel = txtMakeAndModel.Text;
            string homePhone = txtHomePhone.Text;
            string customerName = txtCustomerName.Text;
            string email = txtEmail.Text;
            string yearString = txtYear.Text;
            int year = 0;
            bool isEmailProvided = !string.IsNullOrEmpty(email);

            // Check if postal information is required based on email
            if (!isEmailProvided)
            {
                if (string.IsNullOrEmpty(address))
                {
                    errors.Add("Please enter the address.");
                }

                if (string.IsNullOrEmpty(city))
                {
                    errors.Add("Please enter the city.");
                }

                if (string.IsNullOrEmpty(provinceCode))
                {
                    errors.Add("Please enter the province code.");
                }
                else if (!ValidationHelper.IsValidProvinceCode(provinceCode))
                {
                    errors.Add("Invalid province code. Please enter a valid province code.");
                }
            }

            

            if (!IsValidProvinceCode(provinceCode))
            {
                errors.Add("province code entered is not right ");
            }

            // Validate postal code
            if (!IsValidPostalCode(postalcode))
            {
                errors.Add("This postal code doesn't work.");
            }

            // Validate phone numbers (if provided)
            if (string.IsNullOrEmpty(cellPhone) && string.IsNullOrEmpty(homePhone))
            {
                errors.Add("You must enter a phone number either work");
            }
            if (!IsValidPhoneNumber(cellPhone, homePhone))
            {
                errors.Add("Incorrect cell phone number style entered.");
            }

            if ( !IsValidPhoneNumber(homePhone, cellPhone))
            {
                errors.Add("Incorrect home phone number style entered.");
            }

            if (IsValidProvinceCode(provinceCode))
            {
               provinceCode =  provinceCode.ToUpper();
            }

            // Format postal code
            if (!string.IsNullOrEmpty(postalcode))
            {
                postalcode = postalcode.ToUpper();
                if (!postalcode.Contains(' ') && IsValidPostalCode(postalcode))
                {
                    postalcode = postalcode.Insert(3, " ");
                }
            }

            // Validate customer name and make/model
            if (string.IsNullOrEmpty(customerName))
            {
                errors.Add("Please enter a customer name.");
            }
            else
            {
                customerName = Capitalize(customerName);
            }

            if (string.IsNullOrEmpty(makeAndModel))
            {
                errors.Add("Please enter a make or model.");
            }
            else
            {
                makeAndModel = Capitalize(makeAndModel);
            }

            // Validate and convert year to integer (if provided)
            if (!string.IsNullOrEmpty(yearString))
            {
                if (int.TryParse(yearString, out year))
                {
                    if (year < 1900 || year > 2024)
                    {
                        errors.Add("Please enter a valid year between 1900 and 2024.");
                    }
                }
                else
                {
                    errors.Add("You entered a letter, not a number, for the year. Please enter a number.");
                }
            }

            // Validate email format (if provided)
            try
            {
                if (!string.IsNullOrEmpty(email))
                {
                    MailAddress mailAddress = new MailAddress(email);
                    email = email.ToLower();
                }
            }
            catch (FormatException)
            {
                errors.Add("Invalid email address provided.");
            }

            // Capitalize address and city
            address = Capitalize(address);
            city = Capitalize(city);

            // Validate selected date
            DateTime selectedDate = dtpAppoiment.Value;
            if (selectedDate < DateTime.Today)
            {
                errors.Add("The date entered is in the past. Please pick a future date.");
            }

            // Check if issue description is provided
            if (string.IsNullOrEmpty(rtbInput.Text))
            {
                errors.Add("Please enter a problem or issue you had.");
            }

            // Check if there are any errors
            if (errors.Count > 0)
            {
                // Concatenate all errors and display them in lblMessages
                lblMessages.ForeColor = Color.Red;
                lblMessages.Text = string.Join("\n", errors);
            }
            else
            {
                // No errors, clear lblMessages
                lblMessages.Text = "";

                // Combine all validated information into a single string
                appointmentInfo = $"Customer Name: {customerName}\n" +
                                  $"Address: {address}\n" +
                                  $"City: {city}\n" +
                                  $"Province Code: {provinceCode}\n" +
                                  $"Postal Code: {postalcode}\n" +
                                  $"Cell Phone: {FormatPhoneNumber(cellPhone)}\n" +
                                  $"Home Phone: {FormatPhoneNumber(homePhone)}\n" +
                                  $"Email: {email}\n" +
                                  $"Year: {year}\n" +
                                  $"Make/Model: {makeAndModel}\n" +
                                  $"Appointment Date: {selectedDate.ToString()}\n" +
                                  $"Issue Description: {rtbInput.Text}";

                // Save appointment information to the file
                if (!File.Exists(path))
                {
                    var appointmentsInfo = File.Create(path);
                    appointmentsInfo.Close();
                }

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(appointmentInfo + "\n");
                }

                // Show success message
                lblMessages.ForeColor = Color.DarkGreen;
                lblMessages.Text = "Appointment successfully made.";
            }
            MessageBox.Show(provinceCode);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetFields()
        {
            txtCustomerName.Clear();
            txtCity.Clear();
            txtAddress.Clear();
            txtCellPhone.Clear();
            txtEmail.Clear();
            txtMakeAndModel.Clear();
            txtPostalCode.Clear();
            txtHomePhone.Clear();
            txtProvinceCode.Clear();
            txtYear.Clear();
            dtpAppoiment.ResetText();
            rtbInput.Clear();
            lblMessages.Text = "";
        }

        private void txtHomePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpAppoiment_ValueChanged(object sender, EventArgs e)
        {

        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            // Remove any existing dashes
            phoneNumber = phoneNumber.Replace("-", "").Trim();

            if (phoneNumber.Length == 10)
            {
                // Insert dashes for a 10-digit phone number (1234567890 -> 123-456-7890)
                phoneNumber = phoneNumber.Insert(3, "-").Insert(7, "-");
            }

            return phoneNumber;
        }
    }
}

