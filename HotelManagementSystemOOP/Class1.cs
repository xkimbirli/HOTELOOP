/*using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace HotelManagementSystemOOP
{
    public class InvoicePdfGenerator
    {
        private string cs = @"URI=file:" + Path.Combine(Application.StartupPath, "TOTOO.db");
        private SQLiteConnection con;

        public InvoicePdfGenerator()
        {
            con = new SQLiteConnection(cs);
        }

        public void GenerateInvoicePdf(string filePath, string guestName, string guestPhoneNumber, string guestEmail, int guestKidsNum, int guestAdultNum,
                                       int bookingID, string roomType, string roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header().Text("Invoice").SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    page.Content().PaddingVertical(1, Unit.Centimetre).Column(column =>
                    {
                        column.Spacing(20);

                        column.Item().Text($"Guest Name: {guestName}");
                        column.Item().Text($"Guest Phone Number: {guestPhoneNumber}");
                        column.Item().Text($"Guest Email: {guestEmail}");
                        column.Item().Text($"Number of Kids: {guestKidsNum}");
                        column.Item().Text($"Number of Adults: {guestAdultNum}");
                        column.Item().Text($"Booking ID: {bookingID}");
                        column.Item().Text($"Room Type: {roomType}");
                        column.Item().Text($"Room Number: {roomNumber}");
                        column.Item().Text($"Check-In Date: {checkInDate:yyyy-MM-dd}");
                        column.Item().Text($"Check-Out Date: {checkOutDate:yyyy-MM-dd}");

                        // Load and display hotel information
                        column.Item().Element(container =>
                        {
                            container.Row(row =>
                            {
                                LoadHotelInfo(row);
                            });
                        });

                        // Load and display tax information
                        column.Item().Element(container =>
                        {
                            container.Row(row =>
                            {
                                LoadTaxInfo(row);
                            });
                        });

                        // Load and display payment details
                        column.Item().Element(container =>
                        {
                            container.Row(row =>
                            {
                                LoadPaymentDetails(row, bookingID);
                            });
                        });

                        // Calculate and display total amount
                        column.Item().Text("Total Amount: ").Element(container =>
                        {
                            container.Span(CalculateTotalAmount(bookingID));
                        });
                    });

                    page.Footer().AlignCenter().Text(x =>
                    {
                        x.Span("Page ");
                        x.CurrentPageNumber();
                    });
                });
            });

            document.GeneratePdf(filePath);
        }

        private void LoadHotelInfo(IContainer container)
        {
            con.Open();
            string selectQuery = "SELECT CompanyName, Location, ContactNumber, EmailAddress FROM Hotel";
            using (var command = new SQLiteCommand(selectQuery, con))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        container.Element().Text($"Company Name: {reader["CompanyName"].ToString()}");
                        container.Element().Text($"Address: {reader["Location"].ToString()}");
                        container.Element().Text($"Phone Number: {reader["ContactNumber"].ToString()}");
                        container.Element().Text($"Email: {reader["EmailAddress"].ToString()}");
                    }
                }
            }
            con.Close();
        }

        private void LoadTaxInfo(IContainer container)
        {
            con.Open();
            string selectQuery = "SELECT TaxName, TaxDescription, TaxPercentage FROM Tax";
            using (var command = new SQLiteCommand(selectQuery, con))
            {
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        container.Element().Text($"{row["TaxName"]}: {row["TaxDescription"]} - {row["TaxPercentage"]}%");
                    }
                }
            }
            con.Close();
        }

        private void LoadPaymentDetails(IContainer container, int bookingID)
        {
            con.Open();
            string selectPaymentQuery = "SELECT PaymentStatus, PaymentMethod FROM Payments WHERE BookingID = @BookingID";
            using (var paymentCommand = new SQLiteCommand(selectPaymentQuery, con))
            {
                paymentCommand.Parameters.AddWithValue("@BookingID", bookingID);
                using (var paymentReader = paymentCommand.ExecuteReader())
                {
                    if (paymentReader.Read())
                    {
                        container.Element().Text($"Payment Status: {paymentReader["PaymentStatus"].ToString()}");
                        container.Element().Text($"Payment Method: {paymentReader["PaymentMethod"].ToString()}");
                    }
                }
            }
            con.Close();
        }

        private string CalculateTotalAmount(int bookingID)
        {
            con.Open();
            string totalAmount = "0";
            string selectQuery = "SELECT SUM(Amount) FROM Payments WHERE BookingID = @BookingID";
            using (var command = new SQLiteCommand(selectQuery, con))
            {
                command.Parameters.AddWithValue("@BookingID", bookingID);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    totalAmount = result.ToString();
                }
            }
            con.Close();
            return totalAmount;
        }
    }
}
*/