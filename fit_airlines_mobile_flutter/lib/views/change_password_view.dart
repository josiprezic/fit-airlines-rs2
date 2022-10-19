import 'package:fit_airlines_mobile_flutter/views/components/fit_style_button.dart';
import 'package:fit_airlines_mobile_flutter/views/components/fit_textfield.dart';
import 'package:flutter/material.dart';

class ChangePasswordView extends StatefulWidget {
  const ChangePasswordView({Key? key}) : super(key: key);

  @override
  State<ChangePasswordView> createState() => _ChangePasswordViewState();
}

class _ChangePasswordViewState extends State<ChangePasswordView> {
  double elementMargin = 20;

  void handleUpdatePasswordButtonPressed() {
    print('handleUpdatePasswordButtonPressed');
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Change password'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(20.0),
        child: Column(
          children: [
            FitTextField('Old password'),
            SizedBox(height: elementMargin),
            FitTextField('New password'),
            SizedBox(height: elementMargin),
            FitTextField('Re-type new password'),
            SizedBox(height: elementMargin),
            FitStyleButton(
              'Update password',
              handleUpdatePasswordButtonPressed,
              padding: 0,
            )
          ],
        ),
      ),
    );
  }
}
