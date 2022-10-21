import 'dart:convert';

import 'package:flutter/cupertino.dart';

class ImageService {
  static Image? getImageFromByteData(String? byteData) {
    if (byteData == null || byteData.isEmpty) {
      return null;
    }
    return Image.memory(base64.decode(byteData), fit: BoxFit.cover);
  }
}
