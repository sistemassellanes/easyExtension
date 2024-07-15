
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Packaging;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace EasyAccess
{
      public partial class Main : Form
      {
            private OpenFileDialog openFileDialog;
            private EasyAccessUtil utils;
            DataSet dataSet;

            public Main()
            {
                  InitializeComponent();
                  openFileDialog = new OpenFileDialog();
                  utils = EasyAccessUtil.GetInstance();
                  comboboxCities.Enabled = false;
                  comboBoxClients.Enabled = false;
                  buttonLookForDescription.Enabled = false;
                  buttonExport.Enabled = false;
                  buttonLinde.Enabled = false;
                  Initialize();
                  AutoLoadCities();
                  AutoLoadClients();
            }

            public List<EasyCylinder> listLindeCylinders;
            public Dictionary<string, EasyCylinder> dictionaryLindeCylinders;

            public List<EasyClient> listClients;
            public List<EasyClient> listAuxClients;
            public List<EasyClient> listAuxAuxClients;
            public Dictionary<string, EasyClient> dictionaryClients;

            public List<EasyClient> listClientWithLindeCylinder;
            public Dictionary<string, EasyClient> dictionaryClientWithLindeCylinder;

            public Dictionary<string, EasyLocation> dictionaryLocation;
            public List<EasyLocation> listLocation;
            public Dictionary<string, List<EasyClient>> dictionaryLocationEasyClient;

            public List<EasyCylinder> listEasyCylinder;
            public List<EasyCylinder> listAuxEasyCylinder;
            public Dictionary<string, EasyCylinder> dictionaryEasyCylinder;
            public Dictionary<string, EasyClient> dictionaryEasyCylinderClient;


            void Initialize()
            {
                  listLindeCylinders = new List<EasyCylinder>();
                  dictionaryLindeCylinders = new Dictionary<string, EasyCylinder>();

                  listClients = new List<EasyClient>();
                  listAuxClients = new List<EasyClient>();
                  dictionaryClients = new Dictionary<string, EasyClient>();

                  listClientWithLindeCylinder = new List<EasyClient>();
                  dictionaryClientWithLindeCylinder = new Dictionary<string, EasyClient>();

                  dictionaryLocation = new Dictionary<string, EasyLocation>();
                  listLocation = new List<EasyLocation>();
                  dictionaryLocationEasyClient = new Dictionary<string, List<EasyClient>>();

                  listEasyCylinder = new List<EasyCylinder>();
                  listAuxEasyCylinder = new List<EasyCylinder>();
                  dictionaryEasyCylinder = new Dictionary<string, EasyCylinder>();
                  dictionaryEasyCylinderClient = new Dictionary<string, EasyClient>();

                  dataSet = new DataSet();
            }

            public void ParseClients(string textClients)
            {
                  //Código Nombre  Razon Rut/ Ci / PP / Otro  Teléfono Rubro   Direccion Lista Precio Funcionario
                  string[] lines = textClients.Split(Environment.NewLine);

                  for (int i = 1; i < lines.Length - 1; i++)
                  {
                        string[] columns = lines[i].Split('\t');

                        string clientId = utils.ReplaceAll(columns[0]);
                        string clientCode = utils.ReplaceAll(columns[1]);
                        string clientSocialName = utils.ReplaceAll(columns[2]);
                        string clientRut = utils.ReplaceAll(columns[3]);
                        string clientAddress = utils.ReplaceAll(columns[4].ToLower());
                        string clientCity = utils.ReplaceAll(columns[5].ToLower());
                        string clientName = utils.ReplaceAll(columns[6]);

                        EasyClient easyClient = new EasyClient();
                        easyClient.Id = clientId;
                        easyClient.Code = clientCode;
                        easyClient.SocialNumber = clientSocialName;
                        easyClient.Rut = clientRut;
                        easyClient.Address = clientAddress;

                        easyClient.EasyLocation = dictionaryLocation[clientCity.ToLower()];
                        easyClient.Name = clientName;

                        try
                        {
                              dictionaryClients.Add(clientId, easyClient);
                              List<EasyClient> listEasyClients = dictionaryLocationEasyClient[easyClient.EasyLocation.Description.ToLower()];
                              listEasyClients.Add(easyClient);
                        }
                        catch (Exception e)
                        {
                              Debug.WriteLine("Client ID ERROR: " + easyClient.Id + " Name: " + easyClient.Name);
                        }

                        listClients.Add(easyClient);
                  }
            }

            public void LoadClientDataGrid(List<EasyClient> listClients, bool onlyLinde = false, string filterCylinder = "NONE", string filterCapacity = "NONE")
            {
                  System.Data.DataTable dataTable = new System.Data.DataTable();
                  dataTable.Columns.Add("A");
                  dataTable.Columns.Add("B");
                  dataTable.Columns.Add("C");
                  dataTable.Columns.Add("D");
                  dataTable.Columns.Add("E");
                  dataTable.Columns.Add("F");
                  dataTable.Columns.Add("G");
                  foreach (EasyClient client in listClients)
                  {
                        bool capacities = client.ListCapacity.Count > 0;
                        bool cylinders = client.ListCylinder.Count > 0;

                        if (capacities || cylinders)
                        {

                              dataTable.Rows.Add(new object[] { client.Name, dictionaryLocation[client.EasyLocation.Description].Description.ToUpper(), client.Id, client.Code });

                              if (checkboxCapacities.Checked)
                              {
                                    if (client.ListCapacity.Count > 0)
                                    {
                                          //dataTable.Rows.Add(new object[] { "#", "#", "#", "#", "#", "#", });
                                          dataTable.Rows.Add(new object[] { " ", "EN CLIENTE", "CONTRATADA", "DIFERENCIA" });

                                          foreach (EasyCapacity capacity in client.ListCapacity)
                                          {
                                                if (filterCapacity != "NONE" && capacity.Description.ToLower().Contains(filterCapacity.ToLower()))
                                                {
                                                      dataTable.Rows.Add(new object[] { capacity.Description, capacity.InClient, capacity.Owned, capacity.Difference });
                                                }
                                                else if (filterCapacity == "NONE")
                                                {
                                                      dataTable.Rows.Add(new object[] { capacity.Description, capacity.InClient, capacity.Owned, capacity.Difference });
                                                }

                                          }
                                    }
                              }

                              //dataTable.Rows.Add(new object[] { "#", "#", "#", "#", "#", "#", });

                              if (checkboxCylinders.Checked)
                              {
                                    if (client.ListCylinder.Count > 0)
                                    {
                                          //dataTable.Rows.Add(new object[] { "" });
                                          dataTable.Rows.Add(new object[] { " ", "SERIE", "T-MOV", "N-MOV", "FECHA", "DIAS", "LINDE" });

                                          foreach (EasyCylinder cylinder in client.ListCylinder)
                                          {
                                                if (onlyLinde && (cylinder.ItsLinde || cylinder.ItsAlmostLinde))
                                                {
                                                      dataTable.Rows.Add(new object[] { cylinder.Description, cylinder.Serial, cylinder.MovementType, cylinder.MovementNumber, cylinder.MovementDate, cylinder.Days, cylinder.ItsLindeDescription() });
                                                }
                                                else if (onlyLinde == false)
                                                {
                                                      if (filterCylinder.Equals("NONE") == false && cylinder.Description.ToLower().Contains(filterCylinder))
                                                      {
                                                            dataTable.Rows.Add(new object[] { cylinder.Description, cylinder.Serial, cylinder.MovementType, cylinder.MovementNumber, cylinder.MovementDate, cylinder.Days });
                                                      }
                                                      else
                                                      {
                                                            if (filterCylinder.ToLower().Equals("none"))
                                                            {
                                                                  dataTable.Rows.Add(new object[] { cylinder.Description, cylinder.Serial, cylinder.MovementType, cylinder.MovementNumber, cylinder.MovementDate, cylinder.Days });
                                                            }
                                                            else if (cylinder.Description.ToLower().Contains(filterCylinder.ToLower()))
                                                            {
                                                                  dataTable.Rows.Add(new object[] { cylinder.Description, cylinder.Serial, cylinder.MovementType, cylinder.MovementNumber, cylinder.MovementDate, cylinder.Days });
                                                            }
                                                      }

                                                }
                                          }
                                    }
                              }
                              dataTable.Rows.Add(new object[] { "#", "#", "#", "#", "#", "#", });
                              dataTable.Rows.Add(new object[] { "#", "#", "#", "#", "#", "#", });
                              dataTable.Rows.Add(new object[] { "#", "#", "#", "#", "#", "#", });
                        }
                        dataGridGeneral.DataSource = dataTable;
                        dataGridGeneral.Columns[0].Width = 325;
                  }
            }

            private void ParseLindeCylinders(string textCylinders)
            {
                  List<string> listKeys = dictionaryEasyCylinder.Keys.ToList();
                  string[] lines = textCylinders.Split('\n');
                  labelGeneralStatusValue.Enabled = true;
                  labelGeneralStatusValue.Visible = true;

                  for (int i = 0; i < lines.Length - 1; i++)
                  {
                        labelGeneralStatusValue.Text = i + " de " + lines.Length;
                        labelGeneralStatusValue.Refresh();
                        string[] columns = lines[i].Split("\t");

                        string id = columns[0];
                        EasyCylinder easyCylinder;
                        if (dictionaryEasyCylinder.ContainsKey("CL-" + id))
                        {
                              Debug.WriteLine("Linde: " + true);
                              easyCylinder = dictionaryEasyCylinder["CL-" + id];

                              if (easyCylinder.ItsAlmostLinde)
                              {
                                    easyCylinder.ItsAlmostLinde = false;
                              }

                              easyCylinder.ItsLinde = true;
                              dictionaryLindeCylinders.Add(easyCylinder.Serial, easyCylinder);
                              listLindeCylinders.Add(easyCylinder);
                        }
                        else
                        {
                              string serial = "CL-" + id;

                              foreach (string key in listKeys)
                              {
                                    if (key.Length > 6)
                                    {
                                          if (serial.Contains(key.Substring(0, 7)))
                                          {
                                                Debug.Write("Serial: " + serial + " Contains: " + key.Substring(0, 7) + " Real key: " + key);
                                                if (dictionaryLindeCylinders.ContainsKey(serial) == false)
                                                {
                                                      easyCylinder = dictionaryEasyCylinder[key];
                                                      if (easyCylinder.ItsLinde == false)
                                                      {
                                                            easyCylinder.ItsAlmostLinde = true;
                                                      }
                                                      //easyCylinder.ItsLinde = false;

                                                      dictionaryLindeCylinders.Add(serial, easyCylinder);

                                                      listLindeCylinders.Add(easyCylinder);
                                                }
                                          }
                                    }
                              }

                              Debug.WriteLine("Casi linde: " + true);
                        }
                  }

                  labelGeneralStatusText.Visible = false;
                  labelGeneralStatusValue.Visible = false;
            }


            public void ParseCities(string textLocations)
            {
                  string[] lines = textLocations.Split('\n');

                  for (int i = 0; i < lines.Length - 1; i++)
                  {
                        string location = lines[i].ToString();
                        string[] columns = location.Split("\t");

                        if (columns.Length >= 1)
                        {
                              location = columns[0];
                              EasyLocation easyLocation = new EasyLocation(location.ToLower().TrimEnd());
                              dictionaryLocation.Add(easyLocation.Description, easyLocation);
                              dictionaryLocationEasyClient.Add(easyLocation.Description, new List<EasyClient>());
                              listLocation.Add(easyLocation);

                              //Debug.WriteLine("Key1: " + easyLocation.Description + " Description: " + easyLocation.Description);

                              if (columns.Length == 2)
                              {
                                    dictionaryLocation.Add(columns[1].ToLower().Trim(), easyLocation);
                                    //Debug.WriteLine("Key2: " + columns[1].ToLower().Trim() + " Description: " + easyLocation.Description);
                              }

                              comboboxCities.Items.Add(easyLocation);
                        }
                  }

                  EasyLocation easyEmptyLocation = new EasyLocation("");
                  dictionaryLocation.Add("", easyEmptyLocation);
                  listLocation.Add(easyEmptyLocation);
                  dictionaryLocationEasyClient.Add("", new List<EasyClient>());

                  comboboxCities.SelectedIndex = 0;

                  //Debug.WriteLine("Localidades OK");

                  //buttonLoadCities.Enabled = false;

                  comboboxCities.SelectedIndexChanged += new System.EventHandler(comboboxCities_SelectedIndexChanged);
            }

            public void LogEasyClient()
            {
                  foreach (EasyClient client in listClients)
                  {
                        string log = client.ToString();
                        client.LogCapacity();
                        client.LogCylinders();
                  }
            }

            private void ExportDataSet(DataSet ds, string destination)
            {
                  using (var workbook = SpreadsheetDocument.Create(destination, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
                  {
                        var workbookPart = workbook.AddWorkbookPart();

                        workbook.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                        workbook.WorkbookPart.Workbook.Sheets = new DocumentFormat.OpenXml.Spreadsheet.Sheets();

                        foreach (System.Data.DataTable table in ds.Tables)
                        {
                              var sheetPart = workbook.WorkbookPart.AddNewPart<WorksheetPart>();
                              var sheetData = new DocumentFormat.OpenXml.Spreadsheet.SheetData();
                              sheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(sheetData);

                              DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbook.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>();
                              string relationshipId = workbook.WorkbookPart.GetIdOfPart(sheetPart);

                              uint sheetId = 1;
                              if (sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Count() > 0)
                              {
                                    sheetId =
                                        sheets.Elements<DocumentFormat.OpenXml.Spreadsheet.Sheet>().Select(s => s.SheetId.Value).Max() + 1;
                              }

                              DocumentFormat.OpenXml.Spreadsheet.Sheet sheet = new DocumentFormat.OpenXml.Spreadsheet.Sheet() { Id = relationshipId, SheetId = sheetId, Name = table.TableName };
                              sheets.Append(sheet);

                              DocumentFormat.OpenXml.Spreadsheet.Row headerRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                              List<String> columns = new List<string>();
                              foreach (System.Data.DataColumn column in table.Columns)
                              {
                                    columns.Add(column.ColumnName);

                                    DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                                    cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                                    cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(column.ColumnName);
                                    headerRow.AppendChild(cell);
                              }

                              sheetData.AppendChild(headerRow);

                              foreach (System.Data.DataRow dsrow in table.Rows)
                              {
                                    DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();
                                    foreach (String col in columns)
                                    {
                                          DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                                          cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                                          cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(dsrow[col].ToString()); //
                                          newRow.AppendChild(cell);
                                    }
                                    sheetData.AppendChild(newRow);
                              }
                        }
                  }
            }


            private EasyClient GetClientById(string id)
            {
                  return dictionaryClients[id];
            }

            public void LoadCylinders(string text)
            {
                  List<string> lines = text.Split(Environment.NewLine).ToList();

                  for (int i = 0; i < lines.Count - 1; i++)
                  {
                        string[] columns = lines[i].Split("\t");
                        if (columns[0].Contains("CLIENTE"))
                        {
                              string[] columnsClient = lines[i + 1].Split("\t");
                              EasyClient easyClient = GetClientById(columnsClient[1]);

                              i = i + 2;
                              string[] columnsCapacity = lines[i].Split("\t");

                              if (columnsCapacity[0].Contains("CAPACIDAD"))
                              {
                                    i++; // Paso a la primera capacidad

                                    for (int x = i; ; x++)
                                    {
                                          string s = lines[x].Split("\t")[0];

                                          if ((s.Contains("CILINDROS") && lines[x].Split("\t")[1].Equals("")) == false)
                                          {
                                                string[] capacityLines = lines[x].Split("\t");
                                                string capacityDescription = utils.ReplaceAll(capacityLines[0]);
                                                string inClient = utils.ReplaceAll(capacityLines[1]);
                                                string owned = utils.ReplaceAll(capacityLines[2]);
                                                string difference = utils.ReplaceAll(capacityLines[3]);
                                                EasyCapacity easyCapacity = new EasyCapacity(capacityDescription, inClient, owned, difference);
                                                easyClient.AddCapacity(easyCapacity);
                                          }
                                          else if (s.Contains("CILINDROS"))
                                          {
                                                i = x;
                                                break;
                                          }
                                    }

                                    if (lines[i].Split("\t")[0].Contains("CILINDROS"))
                                    {
                                          i++;

                                          if (lines[i].Split("\t")[1].Contains("ARTICULO"))
                                          {
                                                i++;

                                                while (lines.Count > i && lines[i].Split("\t")[0].Contains("CLIENTE") == false && lines[i].Split("\t")[0].Contains("CILINDROS") == false)
                                                {
                                                      string[] cylinderLines = lines[i].Split("\t");
                                                      string serial = utils.ReplaceAll(cylinderLines[2]);
                                                      string description = utils.ReplaceAll(cylinderLines[1]);
                                                      string movementNumber = utils.ReplaceAll(cylinderLines[4]);
                                                      string movementType = utils.ReplaceAll(cylinderLines[3]);
                                                      string movementDate = utils.ReplaceAll(cylinderLines[5]);
                                                      string days = utils.ReplaceAll(cylinderLines[6]);

                                                      Debug.WriteLine("Description: " + serial);

                                                      EasyCylinder cylinder = new EasyCylinder(serial, description, movementNumber, movementType, movementDate, days);

                                                      easyClient.AddCylinder(cylinder);

                                                      if (dictionaryEasyCylinder.ContainsKey(cylinder.Serial) == false)
                                                      {
                                                            dictionaryEasyCylinder.Add(cylinder.Serial, cylinder);
                                                            listEasyCylinder.Add(cylinder);
                                                            dictionaryEasyCylinderClient.Add(cylinder.Serial, easyClient);
                                                      }
                                                      i++;


                                                      //Debug.WriteLine(i + " de " + lines.Count);
                                                      labelGeneralStatusValue.Text = i + " de " + lines.Count;
                                                      if (i + 1 >= lines.Count)
                                                      {
                                                            break;
                                                      }
                                                }
                                          }
                                          labelGeneralStatusValue.Refresh();
                                          i--;
                                    }
                              }
                        }
                  }

                  comboboxCities.Enabled = false;
                  comboBoxClients.Enabled = false;
                  buttonLoadCylinders.Enabled = false;
                  comboBoxClients.SelectedIndex = 0;

                  //labelCylindersValue.Visible = false;
                  //labelCylindersText.Visible = false;
                  buttonLoadCylinders.Enabled = true;
                  labelStatusCylinders.Text = "OK";
                  comboboxCities.Enabled = true;
                  comboBoxClients.Enabled = true;
                  buttonLoadCylinders.Enabled = false;
                  buttonLoadCylinders.Visible = false;
                  buttonLookForDescription.Enabled = true;
                  buttonExport.Enabled = true;
                  //labelGeneralStatusText.Visible = false;
                  //labelGeneralStatusValue.Visible = false;
                  //buttonLoadCities.Enabled = false;
                  //buttonLoadClients.Enabled = false;

                  labelGeneralStatusValue.Visible = true;
                  labelGeneralStatusText.Text = "Cargando listado linde";

                  //AutoLoadLindeCylinders();
            }



            private void buttonLoadCylinders_Click(object sender, EventArgs e)
            {
                  System.Windows.Forms.OpenFileDialog oDlg = new System.Windows.Forms.OpenFileDialog();
                  oDlg.InitialDirectory = Directory.GetCurrentDirectory() + "\\Archivos";
                  if (System.Windows.Forms.DialogResult.OK == oDlg.ShowDialog())
                  {
                        buttonLoadCylinders.Enabled = false;
                        string textCylinders = System.IO.File.ReadAllText(oDlg.FileName, Encoding.GetEncoding("UTF-8"));
                        LoadCylinders(textCylinders);
                        buttonLinde.Enabled = true;
                  }
            }

            /*
            private void AutoLoadCylinders()
            {
                string textCylinders = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\Archivos\\CILINDROS.txt", Encoding.GetEncoding("UTF-8"));
                LoadCylinders(textCylinders);
            }
            */

            private void buttonAllClients_Click(object sender, EventArgs e)
            {
                  if (openFileDialog.ShowDialog() == DialogResult.OK)
                  {
                        string filePath = openFileDialog.FileName;
                        LoadCylinders(filePath);
                  }
            }


            private void buttonLocations_Click(object sender, EventArgs e)
            {
                  if (openFileDialog.ShowDialog() == DialogResult.OK)
                  {
                        string filePath = openFileDialog.FileName;
                        string textLocations = System.IO.File.ReadAllText(filePath, Encoding.GetEncoding("UTF-8"));
                        ParseCities(textLocations);
                  }
            }

            private void buttonClients_Click(object sender, EventArgs e)
            {
                  if (openFileDialog.ShowDialog() == DialogResult.OK)
                  {
                        string filePath = openFileDialog.FileName;
                        string textClients = System.IO.File.ReadAllText(filePath, Encoding.GetEncoding("UTF-8"));
                        LoadClients(textClients);
                  }
            }




            private void LoadClients(string textClients)
            {
                  //string textClients = System.IO.File.ReadAllText(@"C:\Users\PC\Desktop\EasyAccess\CLIENTES LISTADO.txt", Encoding.GetEncoding("UTF-8"));
                  ParseClients(textClients);

                  comboBoxClients.DataSource = listClients;
                  comboBoxClients.DisplayMember = "Name";
                  comboBoxClients.ValueMember = "Id";

                  //comboBoxClients.SelectionChanged += new SelectionChangedEventHandler(comboBoxClientsSelectionChangeCommitted);

                  labelStatusClients.Text = "OK";

                  //comboBoxClients.valuech
                  //buttonLoadClients.Enabled = false;
            }

            private void comboBoxClients_SelectedValueChanged(object sender, EventArgs e)
            {
                  List<EasyClient> listSelectedClient = new List<EasyClient>();
                  listSelectedClient.Add(comboBoxClients.SelectedItem as EasyClient);
                  LoadClientDataGrid(listSelectedClient);
            }

            //private void textBoxClients_TextChanged(object sender, EventArgs e)

            private void textBoxClients_TextChanged(object sender, EventArgs e)
            {
                  string filter_param = textBoxClients.Text;
                  listAuxClients = listClients.FindAll(client => client.Name.ToLower().Contains(filter_param.ToLower()));

                  comboBoxClients.DataSource = listAuxClients;

                  // if all values removed, bind the original full list again
                  if (String.IsNullOrWhiteSpace(textBoxClients.Text))
                  {
                        comboBoxClients.DataSource = listClients;
                  }

                  // this line will make sure, that the ComboBox opens itself to show the filtered results       
            }


            /*
            private void comboBoxClientsSelectionChangeCommitted(object sender, EventArgs e)
            {
                comboBoxClients.Text = "Name: " + comboBoxClients.SelectedValue.ToString();
            }
            */

            private void LoadCities()
            {
                  //string filePath = openFileDialog.FileName;
                  string textLocations = System.IO.File.ReadAllText(@"C:\Users\PC\Desktop\EasyAccess\CIUDADES.txt", Encoding.GetEncoding("UTF-8"));
                  ParseCities(textLocations);
                  labelStatusCities.Text = "OK";
            }

            private void LoadCylinders()
            {
                  //string filePath = openFileDialog.FileName;
                  comboboxCities.Enabled = false;
                  comboBoxClients.Enabled = false;
                  buttonLoadCylinders.Enabled = false;
                  buttonLoadCylinders.Text = "Espere un momento...";
                  string textLocations = System.IO.File.ReadAllText(@"C:\Users\PC\Desktop\EasyAccess\CILINDROS.txt", Encoding.GetEncoding("UTF-8"));
                  LoadCylinders(textLocations);
                  labelStatusCylinders.Text = "OK";
                  buttonLoadCylinders.Text = "Proceso terminado";
                  //uttonLoadCylinders.Enabled = true;

                  comboboxCities.Enabled = true;
                  comboBoxClients.Enabled = true;
            }

            private void comboboxCities_SelectedIndexChanged(object sender, EventArgs e)
            {
                  List<EasyClient> listClients = dictionaryLocationEasyClient[comboboxCities.Text];
                  LoadClientDataGrid(listClients);
            }

            public void BuildClientsByLocation(List<EasyClient> listClient)
            {
                  StringBuilder stringBuilder = new StringBuilder();

                  foreach (EasyClient client in listClient)
                  {
                        if (client.ListCapacity.Count > 0 || client.ListCylinder.Count > 0)
                        {
                              //BuildClient(client, stringBuilder);
                        }
                  }

                  Debug.WriteLine(stringBuilder.ToString());

                  System.IO.File.WriteAllText(@"C:\Users\PC\Desktop\ClientByLocation.csv", stringBuilder.ToString());
            }


            public void BuildClient(EasyClient client, StringBuilder stringBuilder)
            {
                  if (stringBuilder == null)
                  {
                        stringBuilder = new StringBuilder();
                  }

                  stringBuilder.AppendLine();
                  stringBuilder.Append(client.Name);
                  stringBuilder.Append("\t");
                  stringBuilder.Append(client.Id);
                  stringBuilder.Append("\t");
                  stringBuilder.Append(client.Code);

                  stringBuilder.AppendLine();
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.AppendLine();

                  if (client.ListCapacity.Count > 0)
                  {
                        stringBuilder.Append("CAPACIDAD ");
                        stringBuilder.Append("\t");
                        stringBuilder.Append("EN CLIENTE");
                        stringBuilder.Append("\t");
                        stringBuilder.Append("CONTRATADA ");
                        stringBuilder.Append("\t");
                        stringBuilder.Append("DIFERENCIA ");
                        stringBuilder.AppendLine();

                        foreach (EasyCapacity capacity in client.ListCapacity)
                        {
                              stringBuilder.Append(capacity.Description);
                              stringBuilder.Append("\t");
                              stringBuilder.Append(capacity.InClient);
                              stringBuilder.Append("\t");
                              stringBuilder.Append(capacity.Owned);
                              stringBuilder.Append("\t");
                              stringBuilder.Append(capacity.Difference);
                              stringBuilder.AppendLine();
                        }
                  }

                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.Append("#");
                  stringBuilder.Append("\t");
                  stringBuilder.AppendLine();

                  if (client.ListCylinder.Count > 0)
                  {
                        stringBuilder.Append("CILINDROS ");
                        stringBuilder.Append("\t");
                        stringBuilder.Append("SERIE ");
                        stringBuilder.Append("\t");
                        stringBuilder.Append("T-MOV ");
                        stringBuilder.Append("\t");
                        stringBuilder.Append("N-MOV ");
                        stringBuilder.Append("\t");
                        stringBuilder.Append("FECHA");
                        stringBuilder.Append("\t");
                        stringBuilder.Append("DIAS");
                        stringBuilder.AppendLine();


                        foreach (EasyCylinder cylinder in client.ListCylinder)
                        {
                              stringBuilder.Append(cylinder.Description);
                              stringBuilder.Append("\t");
                              stringBuilder.Append(cylinder.Serial);
                              stringBuilder.Append("\t");
                              stringBuilder.Append(cylinder.MovementType);
                              stringBuilder.Append("\t");
                              stringBuilder.Append(cylinder.MovementNumber);
                              stringBuilder.Append("\t");
                              stringBuilder.Append(cylinder.MovementDate);
                              stringBuilder.Append("\t");
                              stringBuilder.Append(cylinder.Days);
                              stringBuilder.AppendLine();
                        }
                  }
            }

            private void buttonExport_Click(object sender, EventArgs e)
            {
                  SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                  saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\Archivos";
                  saveFileDialog1.DefaultExt = "xlsx";

                  if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                  {
                        string filePath = saveFileDialog1.FileName;
                        dataSet.Clear();
                        dataSet.Tables.Clear();
                        dataSet.Tables.Add(dataGridGeneral.DataSource as System.Data.DataTable);
                        ExportDataSet(dataSet, filePath);
                  }

                  /*
                  if (System.Windows.Forms.DialogResult.OK == oDlg.())
                  {





                      ExportDataSet(dataSet, openFileDialog.InitialDirectory + "archivo.xlsx")
                      labelStatusCities.Text = "OK";
                  }
                  */



            }

            private void buttonLoadCities_Click(object sender, EventArgs e)
            {
                  System.Windows.Forms.OpenFileDialog oDlg = new System.Windows.Forms.OpenFileDialog();
                  oDlg.InitialDirectory = Directory.GetCurrentDirectory() + "\\Archivos";
                  if (System.Windows.Forms.DialogResult.OK == oDlg.ShowDialog())
                  {
                        string textLocations = System.IO.File.ReadAllText(oDlg.FileName, Encoding.GetEncoding("UTF-8"));
                        ParseCities(textLocations);
                        labelStatusCities.Text = "OK";
                  }
            }

            private void AutoLoadCities()
            {
                  string textLocations = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\Archivos\\Internos\\LOCALIDADES.txt", Encoding.GetEncoding("UTF-8"));
                  ParseCities(textLocations);
                  labelStatusCities.Text = "OK";
            }

            private void AutoLoadLindeCylinders()
            {
                  string textClients = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\Archivos\\Internos\\LINDE.txt", Encoding.GetEncoding("UTF-8"));
                  ParseLindeCylinders(textClients);
                  //labelStatusClients.Text = "OK";
            }

            private void AutoLoadClients()
            {
                  string textClients = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\Archivos\\Internos\\CLIENTES.txt", Encoding.GetEncoding("UTF-8"));
                  LoadClients(textClients);
                  labelStatusClients.Text = "OK";
            }

            private void buttonLoadClients_Click(object sender, EventArgs e)
            {
                  string pathClients = "";
                  System.Windows.Forms.OpenFileDialog oDlg = new System.Windows.Forms.OpenFileDialog();
                  oDlg.InitialDirectory = Directory.GetCurrentDirectory() + "\\Archivos";
                  if (System.Windows.Forms.DialogResult.OK == oDlg.ShowDialog())
                  {
                        string textClients = System.IO.File.ReadAllText(oDlg.FileName, Encoding.GetEncoding("UTF-8"));
                        LoadClients(textClients);
                  }
            }

            private void textboxClientId_TextChanged(object sender, EventArgs e)
            {
                  string filter_param = textboxClientId.Text;
                  listAuxClients = listClients.FindAll(client => client.Id.ToLower().Equals(filter_param.ToLower()) || client.Code.ToLower().Equals(filter_param.ToLower()));

                  comboBoxClients.DataSource = listAuxClients;

                  // if all values removed, bind the original full list again
                  /*
                  if (String.IsNullOrWhiteSpace(textboxClientId.Text))
                  {
                        comboBoxClients.DataSource = listClients;
                  }
                  */

                  LoadClientDataGrid(listAuxClients);
            }

            private void textCylinder_TextChanged(object sender, EventArgs e)
            {
                  string filter_param = textboxCylinder.Text;

                  if (dictionaryEasyCylinderClient.ContainsKey(filter_param))
                  {
                        List<EasyClient> list = new List<EasyClient>();
                        list.Add(dictionaryEasyCylinderClient[filter_param]);
                        LoadClientDataGrid(list);
                  }
                  else
                  {
                        List<EasyClient> list = new List<EasyClient>();
                        LoadClientDataGrid(list);
                  }


                  /*
                  comboBoxClients.DataSource = listAuxClients;

                  // if all values removed, bind the original full list again
                  if (String.IsNullOrWhiteSpace(textBoxClients.Text))
                  {
                      comboBoxClients.DataSource = listClients;
                  }
                  */
            }

            /*
            private void textBoxDescription_TextChanged(object sender, EventArgs e)
            {

            }
            */

            private void button1_Click(object sender, EventArgs e)
            {
                  string filter_param = textBoxFilterDescription.Text;
                  listAuxEasyCylinder = listEasyCylinder.FindAll(cylinder => cylinder.Description.ToLower().Contains(filter_param.ToLower()));
                  Dictionary<string, bool> dic = new Dictionary<string, bool>();

                  if (listAuxEasyCylinder.Count > 0)
                  {
                        List<EasyClient> list = new List<EasyClient>();
                        foreach (EasyCylinder easyCilinder in listAuxEasyCylinder)
                        {
                              string clientId = dictionaryEasyCylinderClient[easyCilinder.Serial].Id;
                              if (dic.ContainsKey(clientId) == false)
                              {
                                    dic.Add(clientId, true);
                                    list.Add(dictionaryClients[clientId]);
                              }
                        }

                        list.Sort(delegate (EasyClient client1, EasyClient client2)
                                {
                                      int compareDescription = client1.EasyLocation.Description.CompareTo(client2.EasyLocation.Description);
                                      return compareDescription;
                                }
                            );

                        LoadClientDataGrid(list, false, filter_param, textboxFilterFamilies.Text);
                  }
                  else
                  {
                        List<EasyClient> list = new List<EasyClient>();
                        LoadClientDataGrid(list);
                  }
            }

            private void buttonLinde_Click(object sender, EventArgs e)
            {
                  List<EasyClient> listClientsLindeCylinders = new List<EasyClient>();
                  foreach (EasyClient client in listClients)
                  {
                        if (client.CheckIfIHaveSomeLindeCylinder())
                        {
                              listClientsLindeCylinders.Add(client);
                        }
                  }

                  listClientsLindeCylinders.Sort(delegate (EasyClient client1, EasyClient client2)
                  {
                        int compareDescription = client1.EasyLocation.Description.CompareTo(client2.EasyLocation.Description);
                        return compareDescription;
                  }
                         );

                  LoadClientDataGrid(listClientsLindeCylinders, true);
            }

            private void label2_Click(object sender, EventArgs e)
            {

            }


            /*
            private void comboboxCities_SelectedIndexChanged(object sender, SelectionChangedEventArgs e)
            {
                ComboBox cmb = sender as ComboBox;
                handle = !cmb.IsDropDownOpen;
                Handle();
            }

            private void Handle()
            {
                switch (cmbSelect.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
                {
                    case "1":
                        //Handle for the first combobox
                        break;
                    case "2":
                        //Handle for the second combobox
                        break;
                    case "3":
                        //Handle for the third combobox
                        break;
                }
            }
            */
      }
}
