import 'package:flutter/material.dart';

class FitSelectedSeatHeaderRowView extends StatelessWidget {
  String selectedSeatString;

  FitSelectedSeatHeaderRowView(this.selectedSeatString);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.only(top: 10, bottom: 4),
      child: Center(
        child: Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text(
              'Selected seat: ',
              style: TextStyle(fontSize: 20),
            ),
            Text(
              selectedSeatString,
              style: TextStyle(fontSize: 20),
            ),
          ],
        ),
      ),
    );
  }
}
