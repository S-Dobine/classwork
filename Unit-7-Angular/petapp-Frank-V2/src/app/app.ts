import { Component } from '@angular/core';
import { Homepage } from "./components/homepage/homepage";
import { Router, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [Homepage,RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'petapp';
}
