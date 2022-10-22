import 'package:flutter/material.dart';

class SnackbarManager {
  static showSnackbar(String message, BuildContext context) {
    hideAllSnackbars(context);
    final snackBar = SnackBar(content: Text(message));
    ScaffoldMessenger.of(context).showSnackBar(snackBar);
  }

  static hideAllSnackbars(BuildContext context) {
    ScaffoldMessenger.of(context).hideCurrentSnackBar();
  }
}
