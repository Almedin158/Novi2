// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'kupci.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Kupci _$KupciFromJson(Map<String, dynamic> json) => Kupci()
  ..kupacId = json['kupacId'] as int?
  ..ime = json['ime'] as String?
  ..prezime = json['prezime'] as String?
  ..email = json['email'] as String?;

Map<String, dynamic> _$KupciToJson(Kupci instance) => <String, dynamic>{
      'kupacId': instance.kupacId,
      'ime': instance.ime,
      'prezime': instance.prezime,
      'email': instance.email,
    };
