/*using QuestPDF.Fluent;
using QuestPDF.Headers;

using System;
using System.Windows.Forms;

public class GeneratePDF
{
    private DataGridView dataGridViewGuest;
    private DataGridView dataGridViewRoom;
    private string totalRevenue;
    private string totalOccupancyRate;

    public GeneratePDF(DataGridView dataGridViewGuest, DataGridView dataGridViewRoom, string totalRevenue, string totalOccupancyRate)
    {
        this.dataGridViewGuest = dataGridViewGuest;
        this.dataGridViewRoom = dataGridViewRoom;
        this.totalRevenue = totalRevenue;
        this.totalOccupancyRate = totalOccupancyRate;
    }

    public void Generate()
    {
        var fileName = $"Report_{DateTime.Now:yyyyMMddHHmmss}.pdf";

        // Generate the PDF document using QuestPDF
        var document = new PDFDocument(fileName);
        document.PageHeader(Header);
        document.PageFooter(Footer);
        document.Content(ComposeContent);

        // Save the PDF file
        document.Save(fileName);
    }

    private void Header(HeaderDescriptor descriptor)
    {
        descriptor.Text("Hotel Management System Report")
            .Alignment(HorizontalAlignment.Center)
        .FontSize(20);
    }

    private void Footer(FooterDescriptor descriptor)
    {
        descriptor.Text($"Generated on: {DateTime.Now}")
            .Alignment(HorizontalAlignment.Right)
            .FontSize(10);
    }

    private void ComposeContent(IContainer container, Size availableSpace)
    {
        container.Stack(stack =>
        {
            stack.Item().Text($"Total Revenue: {totalRevenue}")
                .FontSize(16)
                .MarginBottom(10);

            stack.Item().Text($"Total Occupancy Rate: {totalOccupancyRate}")
                .FontSize(16)
                .MarginBottom(10);

            stack.Item().Table(table =>
            {
                table.Columns(4)
                    .Rows(dataGridViewRoom.Rows.Count + 1) // +1 for header row

                    // Header row
                    .HeaderRow(header =>
                    {
                        header.Cell("Room Type");
                        header.Cell("Number of Units");
                        header.Cell("Rented Units");
                        header.Cell("Occupancy Rate");
                        header.Cell("Net Income");
                    })

                    // Data rows
                    .DataRows(dataRows =>
                    {
                        foreach (DataGridViewRow row in dataGridViewRoom.Rows)
                        {
                            dataRows.Cell(row.Cells["RoomType"].Value.ToString());
                            dataRows.Cell(row.Cells["NumberOfUnits"].Value.ToString());
                            dataRows.Cell(row.Cells["RentedUnits"].Value.ToString());
                            dataRows.Cell(row.Cells["OccupancyRate"].Value.ToString());
                            dataRows.Cell(row.Cells["NetIncome"].Value.ToString());
                        }
                    });
            });
        });

        container.Stack(stack =>
        {
            stack.Item().Text("Guest Data")
                .FontSize(16)
                .MarginTop(20)
                .MarginBottom(10);

            stack.Item().Table(table =>
            {
                table.Columns(4)
                    .Rows(dataGridViewGuest.Rows.Count + 1) // +1 for header row

                    // Header row
                    .HeaderRow(header =>
                    {
                        header.Cell("Guest Name");
                        header.Cell("Gender");
                        header.Cell("Nationality");
                        header.Cell("Contact");
                    })

                    // Data rows
                    .DataRows(dataRows =>
                    {
                        foreach (DataGridViewRow row in dataGridViewGuest.Rows)
                        {
                            dataRows.Cell(row.Cells["GuestName"].Value.ToString());
                            dataRows.Cell(row.Cells["Gender"].Value.ToString());
                            dataRows.Cell(row.Cells["Nationality"].Value.ToString());
                            dataRows.Cell(row.Cells["GuestNumber"].Value.ToString());
                        }
                    });
            });
        });
    }
}
*/