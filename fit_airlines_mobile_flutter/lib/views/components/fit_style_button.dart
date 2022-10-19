import 'package:flutter/material.dart';

class FitStyleButton extends StatelessWidget {
  String title;
  Function handleButtonPressed;
  double padding;

  FitStyleButton(this.title, this.handleButtonPressed,
      {this.padding = 8.0, super.key});

  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: 60,
      width: double.infinity,
      child: Padding(
        padding: EdgeInsets.symmetric(
          horizontal: padding,
          vertical: 8.0,
        ),
        child: TextButton(
          style: TextButton.styleFrom(
            foregroundColor: Colors.white,
            backgroundColor: Colors.blue,
          ),
          onPressed: () {
            handleButtonPressed();
          },
          child: Text(title),
        ),
      ),
    );
  }
}
