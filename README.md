# Yamaha Program Analyzer

A Windows Forms application developed for SMT Manufacturing Engineers to analyze Yamaha YGX program files quickly and efficiently.

The tool automatically parses Yamaha program data, extracts component information, builds an internal database, and provides powerful search and inspection capabilities for engineering verification and production support.

---

## Features

### Program File Analysis
- Read Yamaha YGX Program Files
- Parse XML-based Yamaha Data
- Extract Mount Data
- Extract Parts Data
- Extract Component Placement Information
- Extract Package and Feeder Information

### Database Builder
- Automatic Database Generation
- Centralized Data Storage
- Fast Data Retrieval
- Duplicate Detection

### Search Engine
- Search by Component Reference
- Search by Part Number
- Search by Package Type
- Search by Feeder Data
- Search by Mount Information

### Dashboard Inspection
- Total Parts Summary
- Total Mount Summary
- Program Statistics
- Data Validation Support
- Quick Engineering Review

### User Interface
- Windows Desktop Application
- Fast Data Loading
- User-Friendly Interface
- DataGridView-Based Result Display
- Easy Navigation

---

## Application Purpose

This software was developed to support SMT engineering activities by reducing the time required to review Yamaha placement programs.

Typical use cases include:

- New product setup verification
- Program comparison
- Component investigation
- Feeder verification
- Part number traceability
- Engineering analysis
- Production troubleshooting

---

## Technology Stack

### Development Environment

- Visual Studio 2022
- C#
- .NET Framework / Windows Forms

### Core Technologies

- XML Parsing
- LINQ
- DataTable
- DataGridView
- File System Processing

---

## Workflow

```text
YGX Program Files
        │
        ▼
   XML Parser
        │
        ▼
 Database Builder
        │
        ▼
 Search Engine
        │
        ▼
 Dashboard Inspection
```

---

## Project Structure

```text
YamahaProgramAnalyzer
│
├── Forms
│   ├── MainForm
│   ├── SearchForm
│   └── DashboardForm
│
├── Models
│   ├── ComponentData
│   ├── PartData
│   └── MountData
│
├── Services
│   ├── XMLParser
│   ├── DatabaseBuilder
│   └── SearchEngine
│
├── Resources
│
└── README.md
```

---

## Supported Data

The application supports information commonly used in Yamaha SMT programs:

- Reference Designator
- Part Number
- Component Name
- Package Type
- Mount Information
- Feeder Information
- X Position
- Y Position
- Rotation
- Side Layer
- Machine Information

---

## Benefits

### For SMT Engineers

- Reduce manual checking time
- Improve program verification efficiency
- Faster root cause investigation
- Easier component traceability

### For Production Team

- Faster setup verification
- Reduced programming errors
- Improved data accessibility

### For Quality Team

- Better traceability
- Easier defect investigation
- Faster verification process

---

## Future Enhancements

- Multi-Program Comparison
- BOM Comparison
- Export to Excel
- Database Integration
- Advanced Reporting
- Barcode Support
- Real-Time Search Filtering

---

## Screenshots

### Main Dashboard

<img width="1043" height="685" alt="image" src="https://github.com/user-attachments/assets/820c1cf6-29a0-471a-85fc-b1d44e38a530" />

### Analysis Result

<img width="1908" height="896" alt="image" src="https://github.com/user-attachments/assets/e0d5f6b7-da6d-4ee2-82b1-dd5fa2623be4" />


---

## Author

**Husein Abdul Hamid**

SMT Engineer

---

## License

This project is intended for internal engineering and manufacturing support purposes.

All rights reserved.
