import 'dart:core';
import 'dart:convert';
import 'package:http/http.dart' as http;

class APIService {
  static String username = '';
  static String password = '';

  static String socketAddress = "172.25.208.1:25001";
  static String baseUrl = "http://" + socketAddress + "/api/";

  String get baseRouteUrl => baseUrl + route + '/';

  String get basicAuth =>
      'Basic ' + base64.encode(utf8.encode('$username:$password'));

  Map<String, String> get headers => {'authorization': basicAuth};

  String route;

  APIService({required this.route});

  Future<Map<String, dynamic>> getObject({required int id}) async {
    final response = await http.get(Uri.parse(baseRouteUrl), headers: headers);

    if (response.statusCode == 200) {
      final Map<String, dynamic> data = json.decode(response.body);
      return data;
    } else {
      // TODO: JR
      throw Exception('ERROR: STATUS CODE:' + response.statusCode.toString());
    }
  }

  Future<List<dynamic>> getObjectList() async {
    final response = await http.get(Uri.parse(baseRouteUrl), headers: headers);

    if (response.statusCode == 200) {
      final List<dynamic> data = json.decode(response.body);
      return data;
    } else {
      // TODO: JR
      throw Exception('ERROR: STATUS CODE:' + response.statusCode.toString());
    }
  }
}
