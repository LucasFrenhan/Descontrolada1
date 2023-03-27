import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatTable } from '@angular/material/table';
import { ElementDialogComponent } from 'src/app/shared/element-dialog/element-dialog.component';

export interface ProdutoElement {
  id: number,
  nome: string,
  preco: number,
  descricao: string,
  quantidade: number,
}

const ELEMENT_DATA: ProdutoElement[] = [
  { id: 1, nome: 'camiseta', preco: 1.0079, descricao: 'preta básica', quantidade: 10 },
  { id: 2, nome: 'calça', preco: 4.0026, descricao: 'jeans', quantidade: 15 },
];

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  @ViewChild(MatTable)
  table!: MatTable<any>;
  displayedColumns: string[] = ['id', 'nome', 'preco', 'descricao', 'quantidade'];
  dataSource = ELEMENT_DATA;

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  openDialog(element: ProdutoElement | null): void {
    const dialogRef = this.dialog.open(ElementDialogComponent, {
      width: '250px',
      data: element === null ? {
        id: null,
        nome: '',
        preco: null,
        descricao: '',
        quantidade: null
      } : element
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result !== undefined) {
        this.dataSource.push(result);
        this.table.renderRows();
      }
    });
  }
}
