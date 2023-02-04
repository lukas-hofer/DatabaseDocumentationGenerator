# Database Documentation Generator

## Features:
- Generate Data Catalog
  - Export as CSV
  - Export as PDF
- Generate Relation Schema

## How to use:

1. Select your *sql file which contains CREATE TABLE statements
2. After you have selected a script the Data Catalog and Relation Schema is generated automatically

## Data Catalog

The Data Catalog includes

- Table Name
  - Column Name
  - DataType
  - Nullable
  
You can either export your Data Catalog as *.csv or *.pdf

## Relation Schema

The Relation Schema includes
- TableName
  - Column Names
  
in following Format:
`TableName (id, col1, col2)`
