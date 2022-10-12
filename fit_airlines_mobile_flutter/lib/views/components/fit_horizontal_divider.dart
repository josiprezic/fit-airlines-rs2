import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class FitHorizontalDivider extends StatelessWidget {
  const FitHorizontalDivider({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Divider(
      indent: 10,
      endIndent: 10,
      color: Colors.black45,
      thickness: 1,
    );
  }
}
