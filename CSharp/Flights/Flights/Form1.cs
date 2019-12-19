using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flights
{
    public partial class Flights : Form
    {
        const int ARRAYSIZE = 4;

        static string[] flightNumbers = { "201", "321", "510", "633"};
        static string[] airportCodes = { "AUS", "CRP", "DFW", "HOU"};
        static string[] airportNames = { "Austin", "Corpus Christi", "Dallas Fort Worth", "Houstin"};
        static string[] flightTimes = { "0710", "0830", "0915", "1140"};

        public Flights()
        {
            InitializeComponent();
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            textBoxFlightNumber.Text = "";
            textBoxCode.Text = "";
            textBoxAirportName.Text = "";
            textBoxTime.Text = "";
            textBoxFlightInfo.Text = "";
            textBoxSearch.Focus();
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            searchFlights();
        }


        //////
        private void searchFlights()
        {
            string userInput = "";
            userInput = textBoxSearch.Text;

            if (flightNumbers.Contains(userInput))
            {
                for (int i = 0; i < flightNumbers.Length; i++)
                {
                    if (flightNumbers[i] == userInput)
                    {
                        textBoxFlightNumber.Text = flightNumbers[i];
                        textBoxCode.Text = airportCodes[i];
                        textBoxAirportName.Text = airportNames[i];
                        textBoxTime.Text = flightTimes[i];
                        textBoxFlightInfo.Text = "Flight Found";
                    }
                }
            }
            else if (airportCodes.Contains(userInput))
            {
                for (int i = 0; i < airportCodes.Length; i++)
                {
                    if (airportCodes[i] == userInput)
                    {
                        textBoxFlightNumber.Text = flightNumbers[i].ToString();
                        textBoxCode.Text = airportCodes[i];
                        textBoxAirportName.Text = airportNames[i];
                        textBoxTime.Text = flightTimes[i];
                        textBoxFlightInfo.Text = "Flight Found";
                    }
                }
            }
            else
            {
                displayError();
            }
        }

        private void displayError()
        {
            textBoxFlightNumber.Text = "error";
            textBoxCode.Text = "error";
            textBoxAirportName.Text = "error";
            textBoxTime.Text = "error";
            textBoxFlightInfo.Text = "Flight Not Found";
            textBoxSearch.Focus();
        }
    }
}
