using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using DailyTask.Properties;
using System.IO.Compression;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Reflection;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace DailyTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //progressbar propiedades de 3 steps
            progressBar1.Maximum = 3;
        }

        private void ExcelMacro(string ExcelFile, string MacroFileLocation, string Macro)
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            Excel.Application xlApp = new Excel.Application(); //Excel app
            Excel.Workbook xlWbk = null;
            object misValue = System.Reflection.Missing.Value;
            try
            {
                xlWbk = xlApp.Workbooks.Open(ExcelFile);

                string MacroCommand = "'" + MacroFileLocation + "'!" + Macro;
                xlApp.Run(MacroCommand);
            }
            finally
            {
                //Clean up
                if (xlWbk != null)
                    try
                    {
                        xlApp.DisplayAlerts = false;
                        xlWbk.SaveAs(
                            @"\\ramfile01\LGroups\PC&L\CONTROL DE PRODUCCION\REPORTES\45 Exception Reports\F45 Exception Report " +
                            date, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                        xlWbk.Close(true);
                    }
                    catch
                    {
                        //Couldn't save - consider alerting user
                        xlWbk.Close(false);
                    }
                xlApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWbk);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                xlWbk = null;
                xlApp = null;
            }
        }

        private void ExcelMacroOcho(string ExcelFile, string MacroFileLocation, string Macro)
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string fc = monthCalendar1.SelectionRange.Start.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            Excel.Application xlApp = new Excel.Application(); //Excel app
            Excel.Workbook xlWbk = null;
            object misValue = System.Reflection.Missing.Value;
            try
            {
                xlWbk = xlApp.Workbooks.Open(ExcelFile);

                string MacroCommandOcho = "'" + MacroFileLocation + "'!" + Macro;
                xlApp.Run(MacroCommandOcho);
            }
            finally
            {
                //Clean up
                if (xlWbk != null)
                    try
                    {
                        xlApp.DisplayAlerts = false;
                        xlWbk.SaveAs(
                            @"\\\RAMFILE01\LGroups\PC&L\CONTROL DE PRODUCCION\ABR\866 Summary Report\866 summary report " +
                            fc, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                        xlWbk.Close(true);
                    }
                    catch
                    {
                        //Couldn't save - consider alerting user
                        xlWbk.Close(false);
                    }
                xlApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWbk);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                xlWbk = null;
                xlApp = null;
            }
        }

        public void Watcher()
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string fc = monthCalendar1.SelectionRange.Start.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            string shortDate = monthCalendar1.SelectionRange.Start.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            int dayOfWeek = (int) System.DateTime.Now.DayOfWeek;
            int dayOfWeekplus = dayOfWeek + 1;

            //ignoren este espageti 
            string fileNameF = "45 - International 866 Status Report (3320) " + date + ".xlsx";
            string fileNameTrucks = "Navistar Truck Jobs (3320) " + date + ".xlsx";
            string sourcePathTrucks = @"\\ramfile01\Exception_reports\" + fc;
            string sourcePath = @"\\waredi04\reports\ABRSAL";
            string targetPath = @"\\RAMFILE01\LGroups\PC&L\CONTROL DE PRODUCCION\ABR\";
            string pattern = "SAL866Out" + dayOfWeekplus + "_" + shortDate + "_" + "*" + ".csv";

            string[] files = System.IO.Directory.GetFiles(sourcePath, pattern);
            for (int i = 0; i < files.Length; i++)
            {
                estaOkimg866.Visible = true; //866

                estaOkimgPic.Visible = true; //PIC
            }
            string[] filesTrucks = System.IO.Directory.GetFiles(sourcePathTrucks, fileNameTrucks);
            for (int i = 0; i < filesTrucks.Length; i++)
            {
                estaOkimgNav.Visible = true; //  NAVISTAR TRUCKS
            }
            string[] filesF = System.IO.Directory.GetFiles(sourcePathTrucks, fileNameF);
            for (int i = 0; i < filesF.Length; i++)
            {
                estaOkimgF.Visible = true; // F45
            }
        }

        private void OchoSeis() //prepara el archivo de la 866
        {
            //strings de las fechas de los exeption reports

            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string fc = monthCalendar1.SelectionRange.Start.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            string shortDate = monthCalendar1.SelectionRange.Start.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            int dayOfWeek = (int) System.DateTime.Now.DayOfWeek;
            int dayOfWeekplus = dayOfWeek + 1;
            string macroFile = @"\\RAMFILE01\LGroups\PC&L\Software Development\Macros\Macros.xlsb";
            string dummyFile = @"\\RAMFILE01\LGroups\PC&L\Software Development\Macros\Dummy.xlsx";
            string macroSource = @"\\RAMFILE01\LGroups\PC&L\Software Development\Macros";

            progressBar1.Value += 1;
            string sourcePath = @"\\waredi04\reports\ABRSAL";
            string targetPath = @"\\RAMFILE01\LGroups\PC&L\CONTROL DE PRODUCCION\ABR\";
            string pattern = "SAL866Out" + dayOfWeekplus + "_" + shortDate + "_" + "*" + ".csv";

            System.IO.File.Delete(targetPath + "\\" + "SAL866Out.csv");

            string[] files = System.IO.Directory.GetFiles(sourcePath, pattern);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            for (int i = 0; i < files.Length; i++)
            {
                System.IO.File.Copy(files[i], targetPath + Path.GetFileName(files[i]));
                System.IO.File.Move(targetPath + Path.GetFileName(files[i]), targetPath + "SAL866Out.csv");
            }


            progressBar1.Value += 1;

            ExcelMacroOcho(dummyFile, macroFile, "OchoSeisSeis");


            progressBar1.Value += 1;
            MessageBox.Show("Generada 866 con exito!");
            progressBar1.Value = 0;
        }

        private void MoverArchivo() //mueve navistar trucks
        {
            //strings de las fechas de los exeption reports
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string fc = monthCalendar1.SelectionRange.Start.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);


            string fileName = "Navistar Truck Jobs (3320) " + date + ".xlsx";
            string sourcePath = @"\\ramfile01\Exception_reports\" + fc;
            string targetPath = @"\\RAMFILE01\LGroups\PC&L\CONTROL DE PRODUCCION\SIPROD";

            System.IO.File.Delete(targetPath + "\\" + "Navistar Truck Jobs (3320).xlsx");
            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            progressBar1.Value += 1;
            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
            progressBar1.Value += 1;
            // Cambiamos el nombre para quitar el string de la fecha 

            System.IO.File.Move(targetPath + "\\" + "Navistar Truck Jobs (3320) " + date + ".xlsx",
                targetPath + "\\" + "Navistar Truck Jobs (3320).xlsx");

            // Keep console window open in debug mode.
            MessageBox.Show("Trasladado Correctamente!");
            progressBar1.Value = 0;
        }

        private void PicDb() //mueve pic db
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string fc = monthCalendar1.SelectionRange.Start.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
            string shortDate = monthCalendar1.SelectionRange.Start.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
            int dayOfWeek = (int) System.DateTime.Now.DayOfWeek;
            int dayOfWeekplus = dayOfWeek + 1;


            string sourcePath = @"\\waredi04\reports\ABRSAL";
            string targetPath = @"\\RAMFILE01\LGroups\PC&L\CONTROL DE PRODUCCION\ABR\ARCHIVE 866\";


            string pattern = "SAL866Out" + dayOfWeekplus + "_" + shortDate + "_" + "*" + ".csv";
            string patternZip = "abrp" + dayOfWeekplus + "_" + "saltillo" + "_" + shortDate + "_" + "*" + ".zip";
            string patternZip2 = sourcePath + "\\" + "abrp" + dayOfWeekplus + "saltillo" + "_" + shortDate + "_" + "*" +
                                 ".zip";
            string patternZipResult = "Saltillo_866_Detail.txt";

            //Limpiamos contenido viejo
            var dir = new DirectoryInfo(targetPath);

            foreach (var file in dir.EnumerateFiles(pattern))
            {
                file.Delete();
            }
            foreach (var file in dir.EnumerateFiles(patternZipResult))
            {
                file.Delete();
            }

            progressBar1.Value += 1;

            //empezamos a mover cosas
            string[] files = System.IO.Directory.GetFiles(sourcePath, pattern);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            for (int i = 0; i < files.Length; i++)
            {
                System.IO.File.Copy(files[i], targetPath + Path.GetFileName(files[i]));
            }


            //Extraemos el Zip 
            string[] filers = System.IO.Directory.GetFiles(sourcePath, patternZip);

            for (int ai = 0; ai < filers.Length; ai++)
            {
                //System.IO.File.Copy(filers[ai], targetPath + Path.GetFileName(filers[ai]));
                ZipFile.ExtractToDirectory(filers[ai], targetPath);
            }

            progressBar1.Value += 1;


            //finalizamos proceso y reseteamos progressbar

            MessageBox.Show("Trasladado Correctamente!");
            progressBar1.Value = 0;
        }

        private void EfeCuarenta()
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string fc = monthCalendar1.SelectionRange.Start.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);

            progressBar1.Value += 1;
            string fileName = "45 - International 866 Status Report (3320) " + date + ".xlsx";
            string sourcePath = @"\\ramfile01\Exception_reports\" + fc;
            string targetPath = @"\\RAMFILE01\LGroups\PC&L\CONTROL DE PRODUCCION\SIPROD";
            string macroFile = @"\\RAMFILE01\LGroups\PC&L\Software Development\Macros\Macros.xlsb";

            progressBar1.Value += 1;
            ExcelMacro(sourcePath + "\\" + fileName, macroFile, "FCuarenta");
            progressBar1.Value += 1;
            MessageBox.Show("Generado!");
            progressBar1.Value = 0;
        }

        private void btn_NavistarTrucks_Click(object sender, EventArgs e)
        {
            MoverArchivo();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OchoSeis();
        }

        private void btn_picdb_Click(object sender, EventArgs e)
        {
            PicDb();
        }

        private void btn_efeq_Click(object sender, EventArgs e)
        {
            EfeCuarenta();
        }

        private void btn_watcher_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Watcher();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}