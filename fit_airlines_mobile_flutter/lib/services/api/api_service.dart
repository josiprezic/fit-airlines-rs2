import 'dart:core';
import 'dart:convert';
import 'package:http/http.dart' as http;

class APIService {
  static String username = 'member@fit.ba';
  static String password = 'password';

  static String socketAddress = "172.19.112.1:25001";
  static String baseUrl = "http://" + socketAddress + "/api/";

  String get baseRouteUrl => baseUrl + route + '/';
  String get basicAuth => 'Basic ' + base64.encode(utf8.encode('$username:$password'));
  Map<String, String> get headers => {'authorization': basicAuth};
  String route;

  APIService({required this.route});

  Future<Map<String, dynamic>> getObject({String path = '', Map<String, dynamic> queryParams = const {}}) async {
    var uriWithParams = baseRouteUrl + path + buildQueryString(queryParams);

    final response = await http.get(Uri.parse(uriWithParams), headers: headers);
    if (response.statusCode == 200) {
      final Map<String, dynamic> data = json.decode(response.body);
      return data;
    } else {
      // TODO: JR
      throw Exception('ERROR: STATUS CODE:' + response.statusCode.toString());
    }
  }

  bool shouldLog = true;

  Future<List<dynamic>> getObjectList({String path = '', Map<String, dynamic> queryParams = const {}}) async {
    var uriWithParams = baseRouteUrl + path + buildQueryString(queryParams);
    logger('URI with PMS: ' + uriWithParams);
    logger('Authorisation: ' + headers.toString());
    final response = await http.get(Uri.parse(uriWithParams), headers: headers);
    logger('RESPONSE: ' + response.statusCode.toString());

    if (response.statusCode == 200) {
      final List<dynamic> data = json.decode(response.body);
      logger('API SERVICE: returned ' + data.length.toString() + ' objects.');
      return data;
    } else {
      // TODO: JR
      throw Exception('ERROR: STATUS CODE:' + response.statusCode.toString());
    }
  }

  String buildQueryString(Map<String, dynamic> params) {
    if (params.isEmpty) {
      return '';
    }
    var result = '?';
    params.forEach((key, value) {
      result = result + key + '=' + value.toString() + '&';
    });
    result = result.substring(0, result.length - 1);
    return result;
  }

  Future<http.Response> makePostRequest({String path = '', Map<String, dynamic> body = const {}}) async {
    var uriWithParams = baseRouteUrl + path;
    final uri = Uri.parse(uriWithParams);
    //final headers = {'Content-Type': 'application/json'};
    String jsonBody = json.encode(body);
    final encoding = Encoding.getByName('utf-8');

    http.Response response = await http.post(
      uri,
      headers: headers,
      body: jsonBody,
      encoding: encoding,
    );

    logger('POST: Response status code: ' + response.statusCode.toString() + ': ' + response.body);
    return response;
  }

  void logger(String message) {
    if (shouldLog) {
      print(message);
    }
  }
}
