import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { ProdutoElement } from 'src/app/views/home/home.component';

@Component({
  selector: 'app-element-dialog',
  templateUrl: './element-dialog.component.html',
  styleUrls: ['./element-dialog.component.scss']
})
export class ElementDialogComponent implements OnInit {
  element!: ProdutoElement;

  constructor(
    @Inject(MAT_DIALOG_DATA) 
    public data: ProdutoElement,
    public dialogRef: MatDialogRef<ElementDialogComponent>,
    ) { }

  ngOnInit(): void {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

}
