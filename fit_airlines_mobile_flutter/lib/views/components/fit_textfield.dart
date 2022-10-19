import 'package:flutter/material.dart';

class FitTextField extends StatelessWidget {
  String hintText = '';

  FitTextField(this.hintText, {super.key});

  @override
  Widget build(BuildContext context) {
    return TextField(
      decoration: InputDecoration(
        hintText: hintText,
        enabledBorder: OutlineInputBorder(
            borderSide: BorderSide(width: 3, color: Colors.grey)),
        focusedBorder: OutlineInputBorder(
            borderSide: BorderSide(width: 3, color: Colors.blue)),
        errorBorder: OutlineInputBorder(
            borderSide: BorderSide(width: 3, color: Colors.red)),
      ),
    );
  }
}
