<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/02/04 15:07:54">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="9">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="11" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="12" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="13">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32" light_geometry_scale="8" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="26 44 12" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="26 36 12" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="26 44 12" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="5" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="-40 -32 10" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="-28 -32 10" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="-40 -32 10" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="9" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="-24 -31 9" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="11" classname="path_node" gametype="Torque" isPointEntity="1" origin="-24 -38 9" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                    <Entity id="12" classname="path_node" gametype="Torque" isPointEntity="1" origin="-24 -31 9" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="2" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="469">
                    <Brush id="0" owner="0" type="0" pos="0 0 1" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 0 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 4" />
                            <Vertex pos="3 3 -4" />
                            <Vertex pos="3 -3 4" />
                            <Vertex pos="3 -3 -4" />
                            <Vertex pos="-3 3 4" />
                            <Vertex pos="-3 3 -4" />
                            <Vertex pos="-3 -3 4" />
                            <Vertex pos="-3 -3 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile02_B" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="-0.5 4 -7" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 4 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 1 11.5" />
                            <Vertex pos="2.5 1 -12" />
                            <Vertex pos="3.5 -1 12" />
                            <Vertex pos="3.5 -1 -12" />
                            <Vertex pos="-3.5 1 11.5" />
                            <Vertex pos="-3.5 1 -12" />
                            <Vertex pos="-2.5 -1 12" />
                            <Vertex pos="-2.5 -1 -12" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -2.68328" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -2.68328" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 64 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970142 -11.3992" album="" material="bm_tile02_B" texgens="1 0 0 128 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 192 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-1.5 7 -7.25" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 7 0 0 1 -7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.499999 2 9.75" />
                            <Vertex pos="0.499999 2 -11.75" />
                            <Vertex pos="3.5 -2 11.75" />
                            <Vertex pos="3.5 -2 -11.75" />
                            <Vertex pos="-3.5 2 9.75" />
                            <Vertex pos="-3.5 2 -11.75" />
                            <Vertex pos="-2.5 -2 11.75" />
                            <Vertex pos="-2.5 -2 -11.75" />
                        </Vertices>
                        <Face id="0" plane="0.8 0.6 0 -1.6" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970142 -0.242536 0 -2.91043" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 320 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -64 0 0 -1 1056 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -9.61509" album="" material="bm_tile02_B" texgens="1 0 0 -128 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.75" album="" material="bm_grid_blank4" texgens="-1 0 0 320 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-3 10 -8.25" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 10 0 0 1 -8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 10.25" />
                            <Vertex pos="2 1 -10.75" />
                            <Vertex pos="2 -1 10.75" />
                            <Vertex pos="2 -1 -10.75" />
                            <Vertex pos="-2 1 10.25" />
                            <Vertex pos="-2 1 -10.75" />
                            <Vertex pos="-2 -1 10.75" />
                            <Vertex pos="-2 -1 -10.75" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 1184 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 -10.1865" album="" material="bm_tile02_B" texgens="1 0 0 -512 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10.75" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-3 14 -8.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 14 0 0 1 -8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 10.5" />
                            <Vertex pos="2 3 -10.5" />
                            <Vertex pos="2 -3 10.5" />
                            <Vertex pos="2 -3 -10.5" />
                            <Vertex pos="-2 3 10.5" />
                            <Vertex pos="-2 3 -10.5" />
                            <Vertex pos="-2 -3 10.5" />
                            <Vertex pos="-2 -3 -10.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10.5" album="" material="bm_tile02_B" texgens="1 0 0 0 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-3 18 -8.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 18 0 0 1 -8.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 10.5" />
                            <Vertex pos="2 1 -10.5" />
                            <Vertex pos="2 -1 10.5" />
                            <Vertex pos="2 -1 -10.5" />
                            <Vertex pos="-2 1 10.5" />
                            <Vertex pos="-2 1 -10.5" />
                            <Vertex pos="-2 -1 10.5" />
                            <Vertex pos="-2 -1 -10.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1216 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10.5" album="" material="bm_friction_bounce_low" texgens="1 0 0 0 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-3 33 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 33 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 11.5" />
                            <Vertex pos="2 4 -11.5" />
                            <Vertex pos="2 -4 11.5" />
                            <Vertex pos="2 -4 -11.5" />
                            <Vertex pos="-2 4 11.5" />
                            <Vertex pos="-2 4 -11.5" />
                            <Vertex pos="-2 -4 11.5" />
                            <Vertex pos="-2 -4 -11.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 768 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -512 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.5" album="" material="bm_friction_mud" texgens="1 0 0 -768 0 -1 0 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-6 34 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 34 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 11.5" />
                            <Vertex pos="1 3 -11.5" />
                            <Vertex pos="1 -3 11.5" />
                            <Vertex pos="1 -3 -11.5" />
                            <Vertex pos="-1 3 11.5" />
                            <Vertex pos="-1 3 -11.5" />
                            <Vertex pos="-1 -1 11.5" />
                            <Vertex pos="-1 -1 -11.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -1.41421" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.5" album="" material="bm_friction_bounce_low" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.5" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-4 40 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 40 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 13.5" />
                            <Vertex pos="3 3 -13.5" />
                            <Vertex pos="3 -3 13.5" />
                            <Vertex pos="3 -3 -13.5" />
                            <Vertex pos="-3 3 13.5" />
                            <Vertex pos="-3 3 -13.5" />
                            <Vertex pos="-3 -3 13.5" />
                            <Vertex pos="-3 -3 -13.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13.5" album="" material="bm_friction_mud" texgens="1 0 0 -1024 0 -1 0 -10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.5" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-9 35 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 35 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 12.5" />
                            <Vertex pos="2 2 -12.5" />
                            <Vertex pos="2 -2 12.5" />
                            <Vertex pos="2 -2 -12.5" />
                            <Vertex pos="-2 2 12.5" />
                            <Vertex pos="-2 2 -12.5" />
                            <Vertex pos="-2 -2 12.5" />
                            <Vertex pos="-2 -2 -12.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12.5" album="" material="bm_friction_mud" texgens="1 0 0 -2304 0 -1 0 -8960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-10 40 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -10 0 1 0 40 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 12.5" />
                            <Vertex pos="1 3 -12.5" />
                            <Vertex pos="1 -3 12.5" />
                            <Vertex pos="1 -3 -12.5" />
                            <Vertex pos="-1 3 12.5" />
                            <Vertex pos="-1 3 -12.5" />
                            <Vertex pos="-1 -3 12.5" />
                            <Vertex pos="-1 -3 -12.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12.5" album="" material="bm_friction_mud" texgens="1 0 0 -2560 0 -1 0 -10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12.5" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-12 37 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 37 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 12.5" />
                            <Vertex pos="1 4 -12.5" />
                            <Vertex pos="1 -4 12.5" />
                            <Vertex pos="1 -4 -12.5" />
                            <Vertex pos="-1 2 12.5" />
                            <Vertex pos="-1 2 -12.5" />
                            <Vertex pos="-1 -2 12.5" />
                            <Vertex pos="-1 -2 -12.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 -2.12132" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -2.12132" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12.5" album="" material="bm_friction_mud" texgens="1 0 0 -3072 0 -1 0 -9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12.5" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-8 38 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 38 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 12.5" />
                            <Vertex pos="1 1 -12.5" />
                            <Vertex pos="1 -1 12.5" />
                            <Vertex pos="1 -1 -12.5" />
                            <Vertex pos="-1 1 12.5" />
                            <Vertex pos="-1 1 -12.5" />
                            <Vertex pos="-1 -1 12.5" />
                            <Vertex pos="-1 -1 -12.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 384 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12.5" album="" material="bm_friction_mud" texgens="1 0 0 -2048 0 -1 0 -9728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12.5" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-8 41 -6.5" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 41 0 0 1 -6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 12.5" />
                            <Vertex pos="1 2 -12.5" />
                            <Vertex pos="1 -2 12.5" />
                            <Vertex pos="1 -2 -12.5" />
                            <Vertex pos="-1 2 12.5" />
                            <Vertex pos="-1 2 -12.5" />
                            <Vertex pos="-1 -2 12.5" />
                            <Vertex pos="-1 -2 -12.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 960 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -12.5" album="" material="bm_friction_bounce_low" texgens="1 0 0 256 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -12.5" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-3 27 -7.5" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 27 0 0 1 -7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 11.5" />
                            <Vertex pos="2 2 -11.5" />
                            <Vertex pos="2 -2 11.5" />
                            <Vertex pos="2 -2 -11.5" />
                            <Vertex pos="-2 2 11.5" />
                            <Vertex pos="-2 2 -11.5" />
                            <Vertex pos="-2 -2 11.5" />
                            <Vertex pos="-2 -2 -11.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 1024 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -768 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 1088 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -11.5" album="" material="bm_tile02_B" texgens="1 0 0 0 0 -1 0 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -11.5" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="0 40 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 40 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1 13.5" />
                            <Vertex pos="1 1 -13.5" />
                            <Vertex pos="1 -3 13.5" />
                            <Vertex pos="1 -3 -13.5" />
                            <Vertex pos="-1 3 13.5" />
                            <Vertex pos="-1 3 -13.5" />
                            <Vertex pos="-1 -3 13.5" />
                            <Vertex pos="-1 -3 -13.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 -1.41421" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -13.5" album="" material="bm_friction_bounce_low" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13.5" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="4 39 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 39 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 14.5" />
                            <Vertex pos="3 2 -14.5" />
                            <Vertex pos="3 -2 14.5" />
                            <Vertex pos="3 -2 -14.5" />
                            <Vertex pos="-3 2 14.5" />
                            <Vertex pos="-3 2 -14.5" />
                            <Vertex pos="-3 -2 14.5" />
                            <Vertex pos="-3 -2 -14.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.5" album="" material="bm_friction_mud" texgens="1 0 0 1024 0 -1 0 -9984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.5" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="8 39.25 -4.25" rot="1 0 0 0" scale="" transform="1 0 0 8 0 1 0 39.25 0 0 1 -4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 14.75" />
                            <Vertex pos="1 2.25 -14.75" />
                            <Vertex pos="1 -2.25 14.75" />
                            <Vertex pos="1 -2.25 -14.75" />
                            <Vertex pos="-1 1.75 14.25" />
                            <Vertex pos="-1 1.75 -14.75" />
                            <Vertex pos="-1 -2.25 14.25" />
                            <Vertex pos="-1 -2.25 -14.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 32 0 0 -1 672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 224 0 0 -1 672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970143 0 -1.94029" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.25" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 672 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -14.0671" album="" material="bm_friction_mud" texgens="1 0 0 2048 0 -1 0 -10048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.75" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="10 39.5 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 39.5 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.5 15.25" />
                            <Vertex pos="1 2.5 -15.25" />
                            <Vertex pos="1 -2.5 15.25" />
                            <Vertex pos="1 -2.5 -15.25" />
                            <Vertex pos="-1 2 14.25" />
                            <Vertex pos="-1 2 -15.25" />
                            <Vertex pos="-1 -2.5 14.25" />
                            <Vertex pos="-1 -2.5 -15.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 64 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 192 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970143 0 -2.18282" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.5" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -13.1928" album="" material="bm_friction_mud" texgens="1 0 0 2560 0 -1 0 -10112 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="14 40 -3" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 40 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 16" />
                            <Vertex pos="1 3 -16" />
                            <Vertex pos="1 -3 16" />
                            <Vertex pos="1 -3 -16" />
                            <Vertex pos="-1 2.5 15.5" />
                            <Vertex pos="-1 2.5 -16" />
                            <Vertex pos="-1 -3 15.5" />
                            <Vertex pos="-1 -3 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970143 0 -2.66789" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -15.2797" album="" material="bm_tile02_B" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="12 39.75 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 39.75 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.75001 15.75" />
                            <Vertex pos="1 2.75 -15.75" />
                            <Vertex pos="1 -2.75001 15.75" />
                            <Vertex pos="1 -2.75001 -15.75" />
                            <Vertex pos="-1 2.25001 14.75" />
                            <Vertex pos="-1 2.25 -15.75" />
                            <Vertex pos="-1 -2.75001 14.75" />
                            <Vertex pos="-1 -2.75001 -15.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 96 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 160 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970143 -3.084e-007 -2.42536" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2.75001" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -13.64" album="" material="bm_tile02_B" texgens="1 0 0 -768 0 -1 0 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15.75" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="18 40 -3" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 40 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 16" />
                            <Vertex pos="3 3 -16" />
                            <Vertex pos="3 -3 16" />
                            <Vertex pos="3 -3 -16" />
                            <Vertex pos="-3 3 16" />
                            <Vertex pos="-3 3 -16" />
                            <Vertex pos="-3 -3 16" />
                            <Vertex pos="-3 -3 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="23 40 11" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 40 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 2" />
                            <Vertex pos="2 3 0" />
                            <Vertex pos="2 -3 2" />
                            <Vertex pos="2 -3 0" />
                            <Vertex pos="-2 3 2" />
                            <Vertex pos="-2 3 -2" />
                            <Vertex pos="-2 -3 2" />
                            <Vertex pos="-2 -3 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile02_B" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="1" type="999" pos="26 44 12" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 44 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 1" />
                            <Vertex pos="1 3 -1" />
                            <Vertex pos="1 -3 1" />
                            <Vertex pos="1 -3 -1" />
                            <Vertex pos="-1 3 1" />
                            <Vertex pos="-1 3 -1" />
                            <Vertex pos="-1 -3 1" />
                            <Vertex pos="-1 -3 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1" album="" material="bm_tile09_A" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="45 40 11" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 40 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 2" />
                            <Vertex pos="2 3 -2" />
                            <Vertex pos="2 -3 2" />
                            <Vertex pos="2 -3 -2" />
                            <Vertex pos="-2 3 2" />
                            <Vertex pos="-2 3 9.53674e-007" />
                            <Vertex pos="-2 -3 2" />
                            <Vertex pos="-2 -3 9.53674e-007" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -2" album="" material="bm_tile02_B" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.447214 0 -0.894427 -0.894427" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="50 40 -3" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 40 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 16" />
                            <Vertex pos="3 3 -16" />
                            <Vertex pos="3 -3 16" />
                            <Vertex pos="3 -3 -16" />
                            <Vertex pos="-3 3 16" />
                            <Vertex pos="-3 3 -16" />
                            <Vertex pos="-3 -3 16" />
                            <Vertex pos="-3 -3 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_friction_ice" texgens="1 0 0 12800 0 -1 0 -10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="54 40 -3" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 40 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 15.5" />
                            <Vertex pos="1 3 -16" />
                            <Vertex pos="1 -2.5 15.5" />
                            <Vertex pos="1 -2.5 -16" />
                            <Vertex pos="-1 3 16" />
                            <Vertex pos="-1 3 -16" />
                            <Vertex pos="-1 -3 16" />
                            <Vertex pos="-1 -3 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970143 0 -2.66789" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -15.2797" album="" material="bm_friction_ice" texgens="1 0 0 13824 0 -1 0 -10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="56 40.25 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 56 0 1 0 40.25 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.74999 14.75" />
                            <Vertex pos="1 2.75 -15.75" />
                            <Vertex pos="1 -1.75 14.75" />
                            <Vertex pos="1 -1.75 -15.75" />
                            <Vertex pos="-1 2.74999 15.75" />
                            <Vertex pos="-1 2.75 -15.75" />
                            <Vertex pos="-1 -2.75 15.75" />
                            <Vertex pos="-1 -2.75 -15.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 160 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 96 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 3.28314e-007 -2.74999" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.01246" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 544 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -13.64" album="" material="bm_friction_ice" texgens="1 0 0 14336 0 -1 0 -10304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -15.75" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="58 40.75 -3.75" rot="1 0 0 0" scale="" transform="1 0 0 58 0 1 0 40.75 0 0 1 -3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 14.75" />
                            <Vertex pos="1 2.25 -15.25" />
                            <Vertex pos="1 -1.75 14.75" />
                            <Vertex pos="1 -1.75 -15.25" />
                            <Vertex pos="-1 2.25 15.25" />
                            <Vertex pos="-1 2.25 -15.25" />
                            <Vertex pos="-1 -2.25 15.25" />
                            <Vertex pos="-1 -2.25 -15.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 224 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 32 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970143 0 -1.94029" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -14.5521" album="" material="bm_friction_ice" texgens="1 0 0 14848 0 -1 0 -10432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -15.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="65 41 -4" rot="1 0 0 0" scale="" transform="1 0 0 65 0 1 0 41 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 2 14" />
                            <Vertex pos="6 2 -15" />
                            <Vertex pos="6 -2 14" />
                            <Vertex pos="6 -2 -15" />
                            <Vertex pos="-6 2 15" />
                            <Vertex pos="-6 2 -15" />
                            <Vertex pos="-6 -2 15" />
                            <Vertex pos="-6 -2 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.0830455 0 0.996546 -14.4499" album="" material="bm_friction_ice" texgens="1 0 0 16640 0 -1 0 -10496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="73 41 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 73 0 1 0 41 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 14.5" />
                            <Vertex pos="2 2 -14.5" />
                            <Vertex pos="2 -2 14.5" />
                            <Vertex pos="2 -2 -14.5" />
                            <Vertex pos="-2 2 14.5" />
                            <Vertex pos="-2 2 -14.5" />
                            <Vertex pos="-2 -2 14.5" />
                            <Vertex pos="-2 -2 -14.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14.5" album="" material="bm_friction_ice" texgens="1 0 0 18688 0 -1 0 -10496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.5" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="73 33 -4.5" rot="1 0 0 0" scale="" transform="1 0 0 73 0 1 0 33 0 0 1 -4.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 6 14.5" />
                            <Vertex pos="2 6 -14.5" />
                            <Vertex pos="2 -6 13.5" />
                            <Vertex pos="2 -6 -14.5" />
                            <Vertex pos="-2 6 14.5" />
                            <Vertex pos="-2 6 -14.5" />
                            <Vertex pos="-2 -6 13.5" />
                            <Vertex pos="-2 -6 -14.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 512 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.0830455 0.996546 -13.9516" album="" material="bm_friction_ice" texgens="1 0 0 18688 0 -1 0 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14.5" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="73 26 -5" rot="1 0 0 0" scale="" transform="1 0 0 73 0 1 0 26 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 1 14" />
                            <Vertex pos="2 1 -14" />
                            <Vertex pos="2 -1 14" />
                            <Vertex pos="2 -1 -14" />
                            <Vertex pos="-2 1 14" />
                            <Vertex pos="-2 1 -14" />
                            <Vertex pos="-2 -1 14" />
                            <Vertex pos="-2 -1 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_friction_ice" texgens="1 0 0 18688 0 -1 0 -6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="73 6 -6" rot="1 0 0 0" scale="" transform="1 0 0 73 0 1 0 6 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 5 13" />
                            <Vertex pos="2 5 -13" />
                            <Vertex pos="2 -3 13" />
                            <Vertex pos="2 -3 -13" />
                            <Vertex pos="-2 5 13" />
                            <Vertex pos="-2 5 -13" />
                            <Vertex pos="-2 -3 13" />
                            <Vertex pos="-2 -3 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -5" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile02_B" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="72.75 2 -6" rot="1 0 0 0" scale="" transform="1 0 0 72.75 0 1 0 2 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 1 13" />
                            <Vertex pos="2.25 1 -13" />
                            <Vertex pos="2.25 -1 13" />
                            <Vertex pos="2.25 -1 -13" />
                            <Vertex pos="-1.74999 1 13" />
                            <Vertex pos="-1.74999 1 -13" />
                            <Vertex pos="-2.24999 -1 13" />
                            <Vertex pos="-2.24999 -1 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.25" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 -1.94028" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 544 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -288 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile02_B" texgens="1 0 0 -576 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 544 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="72.25 0 -6" rot="1 0 0 0" scale="" transform="1 0 0 72.25 0 1 0 0 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 1 13" />
                            <Vertex pos="2.75 1 -13" />
                            <Vertex pos="2.75 -1 13" />
                            <Vertex pos="2.75 -1 -13" />
                            <Vertex pos="-1.75 1 13" />
                            <Vertex pos="-1.75 1 -13" />
                            <Vertex pos="-2.75 -1 13" />
                            <Vertex pos="-2.75 -1 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.75" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -2.01246" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 608 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -352 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile02_B" texgens="1 0 0 -704 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 608 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="72 -2 -6" rot="1 0 0 0" scale="" transform="1 0 0 72 0 1 0 -2 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 1 13" />
                            <Vertex pos="3 1 -13" />
                            <Vertex pos="3 -1 13" />
                            <Vertex pos="3 -1 -13" />
                            <Vertex pos="-2.49999 1 13" />
                            <Vertex pos="-2.49999 1 -13" />
                            <Vertex pos="-2.99999 -1 13" />
                            <Vertex pos="-2.99999 -1 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 -2.66788" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile02_B" texgens="1 0 0 -768 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="72 -6 -6" rot="1 0 0 0" scale="" transform="1 0 0 72 0 1 0 -6 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 13" />
                            <Vertex pos="3 3 -13" />
                            <Vertex pos="3 -3 13" />
                            <Vertex pos="3 -3 -13" />
                            <Vertex pos="-3 3 13" />
                            <Vertex pos="-3 3 -13" />
                            <Vertex pos="-3 -3 13" />
                            <Vertex pos="-3 -3 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile02_B" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="50 34 6.5" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 34 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 25.5" />
                            <Vertex pos="3 3 -25.5" />
                            <Vertex pos="3 -3 25.5" />
                            <Vertex pos="3 -3 -25.5" />
                            <Vertex pos="-3 3 18.5" />
                            <Vertex pos="-3 3 -25.5" />
                            <Vertex pos="-3 -3 18.5" />
                            <Vertex pos="-3 -3 -25.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.759257 0 0.650791 -14.3174" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -25.5" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="54 34.25 7.25" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 34.25 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3.25 26.25" />
                            <Vertex pos="1 3.25 -26.25" />
                            <Vertex pos="1 -3.25 26.25" />
                            <Vertex pos="1 -3.25 -26.25" />
                            <Vertex pos="-1 2.75 24.75" />
                            <Vertex pos="-1 2.75 -26.25" />
                            <Vertex pos="-1 -3.25 24.75" />
                            <Vertex pos="-1 -3.25 -26.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 160 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 96 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970143 0 -2.91043" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.25" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.6 0 0.8 -20.4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="56 34.75 7.75" rot="1 0 0 0" scale="" transform="1 0 0 56 0 1 0 34.75 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999996 3.75 26.75" />
                            <Vertex pos="0.999996 3.75 -26.75" />
                            <Vertex pos="0.999996 -3.75 26.75" />
                            <Vertex pos="0.999996 -3.75 -26.75" />
                            <Vertex pos="-0.999996 2.75 25.75" />
                            <Vertex pos="-0.999996 2.75 -26.75" />
                            <Vertex pos="-0.999996 -3.75 25.75" />
                            <Vertex pos="-0.999996 -3.75 -26.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.999996" album="" material="bm_grid_blank4" texgens="0 1 0 224 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.999996" album="" material="bm_grid_blank4" texgens="0 -1 0 32 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447215 0.894426 0 -2.90689" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3.75" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447215 0 0.894427 -23.4787" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.75" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="58 35 8" rot="1 0 0 0" scale="" transform="1 0 0 58 0 1 0 35 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 27" />
                            <Vertex pos="1 4 -27" />
                            <Vertex pos="1 -4 27" />
                            <Vertex pos="1 -4 -27" />
                            <Vertex pos="-1 3.5 26.5" />
                            <Vertex pos="-1 3.5 -27" />
                            <Vertex pos="-1 -4 26.5" />
                            <Vertex pos="-1 -4 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970142 0 -3.63803" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -25.9513" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="62 35 8" rot="1 0 0 0" scale="" transform="1 0 0 62 0 1 0 35 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 27" />
                            <Vertex pos="3 4 -27" />
                            <Vertex pos="3 -4 27" />
                            <Vertex pos="3 -4 -27" />
                            <Vertex pos="-3 4 27" />
                            <Vertex pos="-3 4 -27" />
                            <Vertex pos="-3 -4 27" />
                            <Vertex pos="-3 -4 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="50 46 6.5" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 46 0 0 1 6.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 25.5" />
                            <Vertex pos="3 3 -25.5" />
                            <Vertex pos="3 -3 25.5" />
                            <Vertex pos="3 -3 -25.5" />
                            <Vertex pos="-3 3 18.5" />
                            <Vertex pos="-3 3 -25.5" />
                            <Vertex pos="-3 -3 18.5" />
                            <Vertex pos="-3 -3 -25.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -704 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.759257 0 0.650791 -14.3174" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -25.5" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="54 40 27.25" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 40 0 0 1 27.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 6.25" />
                            <Vertex pos="1 3 -8.25" />
                            <Vertex pos="1 -2.5 6.25" />
                            <Vertex pos="1 -2.5 -8.25" />
                            <Vertex pos="-1 3 4.75" />
                            <Vertex pos="-1 3 -8.25" />
                            <Vertex pos="-1 -3 4.75" />
                            <Vertex pos="-1 -3 -8.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -3360 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -3360 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -3360 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970143 0 -2.66789" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -3360 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.6 0 0.8 -4.4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -8.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="56 40.25 27.75" rot="1 0 0 0" scale="" transform="1 0 0 56 0 1 0 40.25 0 0 1 27.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999996 2.75 6.75" />
                            <Vertex pos="0.999996 2.75 -8.75" />
                            <Vertex pos="0.999996 -1.75 6.75" />
                            <Vertex pos="0.999996 -1.75 -8.75" />
                            <Vertex pos="-0.999996 2.75 5.75" />
                            <Vertex pos="-0.999996 2.75 -8.75" />
                            <Vertex pos="-0.999996 -2.75 5.75" />
                            <Vertex pos="-0.999996 -2.75 -8.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.999996" album="" material="bm_grid_blank4" texgens="0 1 0 160 0 0 -1 -3424 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.999996" album="" material="bm_grid_blank4" texgens="0 -1 0 96 0 0 -1 -3424 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.75" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -3424 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447215 -0.894426 0 -2.01246" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -3424 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447215 0 0.894426 -5.59017" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -8.75" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="58 40.75 28" rot="1 0 0 0" scale="" transform="1 0 0 58 0 1 0 40.75 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 7" />
                            <Vertex pos="1 2.25 -9" />
                            <Vertex pos="1 -1.75 7" />
                            <Vertex pos="1 -1.75 -9" />
                            <Vertex pos="-1 2.25 6.5" />
                            <Vertex pos="-1 2.25 -9" />
                            <Vertex pos="-1 -2.25 6.5" />
                            <Vertex pos="-1 -2.25 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 224 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 32 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970142 0 -1.94028" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -6.54846" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="54 46 7.25" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 46 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 26.25" />
                            <Vertex pos="1 3 -26.25" />
                            <Vertex pos="1 -3 26.25" />
                            <Vertex pos="1 -3 -26.25" />
                            <Vertex pos="-1 3 24.75" />
                            <Vertex pos="-1 3 -26.25" />
                            <Vertex pos="-1 -3 24.75" />
                            <Vertex pos="-1 -3 -26.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -800 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.6 0 0.8 -20.4" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="56 46 7.75" rot="1 0 0 0" scale="" transform="1 0 0 56 0 1 0 46 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999996 3 26.75" />
                            <Vertex pos="0.999996 3 -26.75" />
                            <Vertex pos="0.999996 -3 26.75" />
                            <Vertex pos="0.999996 -3 -26.75" />
                            <Vertex pos="-0.999996 3 25.75" />
                            <Vertex pos="-0.999996 3 -26.75" />
                            <Vertex pos="-0.999996 -3 25.75" />
                            <Vertex pos="-0.999996 -3 -26.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.999996" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.999996" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447215 0 0.894426 -23.4787" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.75" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="58 46 8" rot="1 0 0 0" scale="" transform="1 0 0 58 0 1 0 46 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 27" />
                            <Vertex pos="1 3 -27" />
                            <Vertex pos="1 -3 27" />
                            <Vertex pos="1 -3 -27" />
                            <Vertex pos="-1 3 26.5" />
                            <Vertex pos="-1 3 -27" />
                            <Vertex pos="-1 -3 26.5" />
                            <Vertex pos="-1 -3 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970142 -25.9513" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="62 46 8" rot="1 0 0 0" scale="" transform="1 0 0 62 0 1 0 46 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 27" />
                            <Vertex pos="3 3 -27" />
                            <Vertex pos="3 -3 27" />
                            <Vertex pos="3 -3 -27" />
                            <Vertex pos="-3 3 27" />
                            <Vertex pos="-3 3 -27" />
                            <Vertex pos="-3 -3 27" />
                            <Vertex pos="-3 -3 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="50 40 25.5" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 40 0 0 1 25.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 6.5" />
                            <Vertex pos="3 3 -6.5" />
                            <Vertex pos="3 -3 6.5" />
                            <Vertex pos="3 -3 -6.5" />
                            <Vertex pos="-3 3 -0.499998" />
                            <Vertex pos="-3 3 -6.5" />
                            <Vertex pos="-3 -3 -0.499998" />
                            <Vertex pos="-3 -3 -6.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.759257 0 0.650791 -1.95238" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6.5" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="62 41 28" rot="1 0 0 0" scale="" transform="1 0 0 62 0 1 0 41 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 7" />
                            <Vertex pos="3 2 -9" />
                            <Vertex pos="3 -2 7" />
                            <Vertex pos="3 -2 -9" />
                            <Vertex pos="-3 2 7" />
                            <Vertex pos="-3 2 -9" />
                            <Vertex pos="-3 -2 7" />
                            <Vertex pos="-3 -2 -9" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -7" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="68 35 8" rot="1 0 0 0" scale="" transform="1 0 0 68 0 1 0 35 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 27" />
                            <Vertex pos="3 4 -27" />
                            <Vertex pos="3 -4 27" />
                            <Vertex pos="3 -4 -27" />
                            <Vertex pos="-3 4 27" />
                            <Vertex pos="-3 4 -27" />
                            <Vertex pos="-3 -4 27" />
                            <Vertex pos="-3 -4 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="68 46 8" rot="1 0 0 0" scale="" transform="1 0 0 68 0 1 0 46 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 27" />
                            <Vertex pos="3 3 -27" />
                            <Vertex pos="3 -3 27" />
                            <Vertex pos="3 -3 -27" />
                            <Vertex pos="-3 3 27" />
                            <Vertex pos="-3 3 -27" />
                            <Vertex pos="-3 -3 27" />
                            <Vertex pos="-3 -3 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -27" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="68 41 27" rot="1 0 0 0" scale="" transform="1 0 0 68 0 1 0 41 0 0 1 27 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 8" />
                            <Vertex pos="3 2 -10" />
                            <Vertex pos="3 -2 8" />
                            <Vertex pos="3 -2 -10" />
                            <Vertex pos="-3 2 8" />
                            <Vertex pos="-3 2 -8" />
                            <Vertex pos="-3 -2 8" />
                            <Vertex pos="-3 -2 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.316228 0 -0.948683 -8.53815" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="73 46 8" rot="1 0 0 0" scale="" transform="1 0 0 73 0 1 0 46 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.99999 3 26" />
                            <Vertex pos="1.99999 3 -27" />
                            <Vertex pos="1.99999 -3 26" />
                            <Vertex pos="1.99999 -3 -27" />
                            <Vertex pos="-1.99999 3 27" />
                            <Vertex pos="-1.99999 3 -27" />
                            <Vertex pos="-1.99999 -3 27" />
                            <Vertex pos="-1.99999 -3 -27" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1.99999" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.99999" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242537 0 0.970142 -25.7088" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -27" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="78 40 7.5" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 40 0 0 1 7.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.00001 9 23.5" />
                            <Vertex pos="3.00001 9 -26.5" />
                            <Vertex pos="3.00001 -9 23.5" />
                            <Vertex pos="3.00001 -9 -26.5" />
                            <Vertex pos="-3.00001 9 26.5" />
                            <Vertex pos="-3.00001 9 -26.5" />
                            <Vertex pos="-3.00001 -9 26.5" />
                            <Vertex pos="-3.00001 -9 -26.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3.00001" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.00001" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -9" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -9" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -832 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447212 0 0.894428 -22.3607" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -26.5" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="73 41 27" rot="1 0 0 0" scale="" transform="1 0 0 73 0 1 0 41 0 0 1 27 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 7" />
                            <Vertex pos="2 2 -10" />
                            <Vertex pos="2 -2 7" />
                            <Vertex pos="2 -2 -10" />
                            <Vertex pos="-2 2 8" />
                            <Vertex pos="-2 2 -10" />
                            <Vertex pos="-2 -2 8" />
                            <Vertex pos="-2 -2 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -7.27607" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="73 35 26" rot="1 0 0 0" scale="" transform="1 0 0 73 0 1 0 35 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 4 8" />
                            <Vertex pos="2 4 -9" />
                            <Vertex pos="2 -4 8" />
                            <Vertex pos="2 -4 -11" />
                            <Vertex pos="-2 4 9" />
                            <Vertex pos="-2 4 -9" />
                            <Vertex pos="-2 -4 9" />
                            <Vertex pos="-2 -4 -11" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -8.24621" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -9.70143" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="63 -6 -3" rot="1 0 0 0" scale="" transform="1 0 0 63 0 1 0 -6 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 16" />
                            <Vertex pos="6 3 -16" />
                            <Vertex pos="6 -3 16" />
                            <Vertex pos="6 -3 -16" />
                            <Vertex pos="-6 3 16" />
                            <Vertex pos="-6 3 -16" />
                            <Vertex pos="-6 -3 16" />
                            <Vertex pos="-6 -3 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -768 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_tile02_B" texgens="1 0 0 -1536 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="72 -12 0" rot="1 0 0 0" scale="" transform="1 0 0 72 0 1 0 -12 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 19" />
                            <Vertex pos="3 3 -19" />
                            <Vertex pos="3 -3 19" />
                            <Vertex pos="3 -3 -19" />
                            <Vertex pos="-3 3 19" />
                            <Vertex pos="-3 3 -19" />
                            <Vertex pos="-3 -3 19" />
                            <Vertex pos="-3 -3 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_friction_sand" texgens="-1 0 0 -9216 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile02_B" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="78 -6 3" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 -6 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 20" />
                            <Vertex pos="3 3 -22" />
                            <Vertex pos="3 -3 22" />
                            <Vertex pos="3 -3 -22" />
                            <Vertex pos="-3 3 20" />
                            <Vertex pos="-3 3 -22" />
                            <Vertex pos="-3 -3 22" />
                            <Vertex pos="-3 -3 -22" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.316228 0.948683 -19.9223" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -22" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="72 -12 25" rot="1 0 0 0" scale="" transform="1 0 0 72 0 1 0 -12 0 0 1 25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 6" />
                            <Vertex pos="3 3 -6" />
                            <Vertex pos="3 -3 6" />
                            <Vertex pos="3 -3 -6" />
                            <Vertex pos="-3 3 2" />
                            <Vertex pos="-3 3 -6" />
                            <Vertex pos="-3 -3 2" />
                            <Vertex pos="-3 -3 -6" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.5547 0 0.83205 -3.3282" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="78 -12 6" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 -12 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 25" />
                            <Vertex pos="3 3 -25" />
                            <Vertex pos="3 -3 25" />
                            <Vertex pos="3 -3 -25" />
                            <Vertex pos="-3 3 25" />
                            <Vertex pos="-3 3 -25" />
                            <Vertex pos="-3 -3 25" />
                            <Vertex pos="-3 -3 -25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -25" album="" material="bm_tile02_B" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -25" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="66 -12 2" rot="1 0 0 0" scale="" transform="1 0 0 66 0 1 0 -12 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 21" />
                            <Vertex pos="3 3 -21" />
                            <Vertex pos="3 -3 21" />
                            <Vertex pos="3 -3 -21" />
                            <Vertex pos="-3 3 19" />
                            <Vertex pos="-3 3 -21" />
                            <Vertex pos="-3 -3 19" />
                            <Vertex pos="-3 -3 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.316228 0 0.948683 -18.9737" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="4 12.75 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 12.75 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 15.75" />
                            <Vertex pos="1 2.25 -16.75" />
                            <Vertex pos="1 -1.75 15.75" />
                            <Vertex pos="1 -1.75 -16.75" />
                            <Vertex pos="-1 2.25 16.75" />
                            <Vertex pos="-1 2.25 -16.75" />
                            <Vertex pos="-1 -2.25 16.75" />
                            <Vertex pos="-1 -2.25 -16.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 224 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0.0020752 0 0 -1 416 0 0.28125 0.25" texRot="0" texScale="0.28125 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970142 0 -1.94028" album="" material="bm_grid_blank4" texgens="1 0 0 -1408 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 0.894427 -14.5344" album="" material="bm_friction_ice" texgens="1 0 0 1024 0 -1 0 -3264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="-11 6 -2.5" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 6 0 0 1 -2.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 8 16.5" />
                            <Vertex pos="6 8 -16.5" />
                            <Vertex pos="6 2 16.5" />
                            <Vertex pos="6 2 -16.5" />
                            <Vertex pos="-6 -2 10.5" />
                            <Vertex pos="-6 -2 -16.5" />
                            <Vertex pos="-6 -8 10.5" />
                            <Vertex pos="-6 -8 -16.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.640184 0.768221 0 -2.30466" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.640184 -0.768221 0 -2.30466" album="" material="bm_grid_blank4" texgens="1 0 0 -2048 0 0 -1 448 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -12.0748" album="" material="bm_tile02_B" texgens="1 0 0 1536 0.833333 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -16.5" album="" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="-4 11.5 11" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 11.5 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3.5 4" />
                            <Vertex pos="1 3.5 -2" />
                            <Vertex pos="1 -2.5 4" />
                            <Vertex pos="1 -2.5 -2" />
                            <Vertex pos="-1 2.5 3" />
                            <Vertex pos="-1 2.5 -4" />
                            <Vertex pos="-1 -3.5 3" />
                            <Vertex pos="-1 -3.5 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 64 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 192 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 -2.68328" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.68328" album="" material="bm_grid_blank4" texgens="1 0 0 -1408 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -3.1305" album="" material="bm_tile02_B" texgens="1 0 0 256 0.5 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -2.12132" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0.5 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="2 12.25 11" rot="1 0 0 0" scale="" transform="1 0 0 2 0 1 0 12.25 0 0 1 11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.75 3.5" />
                            <Vertex pos="1 2.75 -4" />
                            <Vertex pos="1 -1.75 3.5" />
                            <Vertex pos="1 -1.75 -4" />
                            <Vertex pos="-1 2.75 4" />
                            <Vertex pos="-1 2.75 -2" />
                            <Vertex pos="-1 -2.75 4" />
                            <Vertex pos="-1 -2.75 -2" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 160 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 96 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2.75" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.01246" album="" material="bm_grid_blank4" texgens="1 0 0 -1408 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970142 -3.63803" album="" material="bm_tile02_B" texgens="1 0 0 -2816 0 -1 0 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -2.12132" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 -1 0 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="-2 12 12" rot="1 0 0 0" scale="" transform="1 0 0 -2 0 1 0 12 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 3" />
                            <Vertex pos="1 3 -3" />
                            <Vertex pos="1 -3 3" />
                            <Vertex pos="1 -3 -3" />
                            <Vertex pos="-1 3 3" />
                            <Vertex pos="-1 3 -3" />
                            <Vertex pos="-1 -3 3" />
                            <Vertex pos="-1 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="6 13 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 6 0 1 0 13 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 15.75" />
                            <Vertex pos="1 2 -16.25" />
                            <Vertex pos="1 -2 15.75" />
                            <Vertex pos="1 -2 -16.25" />
                            <Vertex pos="-1 2 16.25" />
                            <Vertex pos="-1 2 -16.25" />
                            <Vertex pos="-1 -2 16.25" />
                            <Vertex pos="-1 -2 -16.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -1408 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -15.5223" album="" material="bm_friction_ice" texgens="1 0 0 1536 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.25" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="0 12 12" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 12 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 3" />
                            <Vertex pos="1 3 -3" />
                            <Vertex pos="1 -2.5 3" />
                            <Vertex pos="1 -2.5 -3" />
                            <Vertex pos="-1 3 3" />
                            <Vertex pos="-1 3 -3" />
                            <Vertex pos="-1 -3 3" />
                            <Vertex pos="-1 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970142 0 -2.66789" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile02_B" texgens="1 0 0 -256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="20 13 -2" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 13 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 17" />
                            <Vertex pos="3 2 -17" />
                            <Vertex pos="3 -2 17" />
                            <Vertex pos="3 -2 -17" />
                            <Vertex pos="-3 2 17" />
                            <Vertex pos="-3 2 -17" />
                            <Vertex pos="-3 -2 17" />
                            <Vertex pos="-3 -2 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_friction_ice" texgens="1 0 0 5120 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="54 -6 -3" rot="1 0 0 0" scale="" transform="1 0 0 54 0 1 0 -6 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 16" />
                            <Vertex pos="3 3 -16" />
                            <Vertex pos="3 -3 16" />
                            <Vertex pos="3 -3 -16" />
                            <Vertex pos="-3 2.5 16" />
                            <Vertex pos="-3 2.5 -16" />
                            <Vertex pos="-3 -2 16" />
                            <Vertex pos="-3 -2 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.0830455 0.996546 0 -2.7405" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.164399 -0.986394 -0 -2.46598" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_friction_mud" texgens="1 0 0 13824 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="9 13 -3" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 13 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 16" />
                            <Vertex pos="2 2 -16" />
                            <Vertex pos="2 -2 16" />
                            <Vertex pos="2 -2 -16" />
                            <Vertex pos="-2 2 16" />
                            <Vertex pos="-2 2 -16" />
                            <Vertex pos="-2 -2 16" />
                            <Vertex pos="-2 -2 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -16" album="" material="bm_friction_ice" texgens="1 0 0 2304 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="16 13 -2" rot="1 0 0 0" scale="" transform="1 0 0 16 0 1 0 13 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 17" />
                            <Vertex pos="1 2 -17" />
                            <Vertex pos="1 -2 17" />
                            <Vertex pos="1 -2 -17" />
                            <Vertex pos="-1 2 16.5" />
                            <Vertex pos="-1 2 -17" />
                            <Vertex pos="-1 -2 16.5" />
                            <Vertex pos="-1 -2 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -16.2499" album="" material="bm_friction_ice" texgens="1 0 0 4096 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="14 13 -2.25" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 13 0 0 1 -2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 16.75" />
                            <Vertex pos="1 2 -16.75" />
                            <Vertex pos="1 -2 16.75" />
                            <Vertex pos="1 -2 -16.75" />
                            <Vertex pos="-1 2 15.75" />
                            <Vertex pos="-1 2 -16.75" />
                            <Vertex pos="-1 -2 15.75" />
                            <Vertex pos="-1 -2 -16.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 416 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -14.5344" album="" material="bm_friction_ice" texgens="1 0 0 3584 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.75" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="12 13 -2.75" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 13 0 0 1 -2.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2 16.25" />
                            <Vertex pos="1 2 -16.25" />
                            <Vertex pos="1 -2 16.25" />
                            <Vertex pos="1 -2 -16.25" />
                            <Vertex pos="-1 2 15.75" />
                            <Vertex pos="-1 2 -16.25" />
                            <Vertex pos="-1 -2 15.75" />
                            <Vertex pos="-1 -2 -16.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 -15.5223" album="" material="bm_friction_ice" texgens="1 0 0 3072 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -16.25" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="26 11 -2" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 11 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 4 17" />
                            <Vertex pos="3 4 -17" />
                            <Vertex pos="3 -4 17" />
                            <Vertex pos="3 -4 -17" />
                            <Vertex pos="-3 4 17" />
                            <Vertex pos="-3 4 -17" />
                            <Vertex pos="-3 -4 17" />
                            <Vertex pos="-3 -4 -17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -4" album="" material="bm_grid_blank4" texgens="1 0 0 -640 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -17" album="" material="bm_tile02_B" texgens="1 0 0 -1280 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 896 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="48 -5.75 -3" rot="1 0 0 0" scale="" transform="1 0 0 48 0 1 0 -5.75 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2.25 16" />
                            <Vertex pos="3 2.25 -16" />
                            <Vertex pos="3 -2.25 16" />
                            <Vertex pos="3 -2.25 -16" />
                            <Vertex pos="-3 2.75 16" />
                            <Vertex pos="-3 2.75 -16" />
                            <Vertex pos="-3 -2.75 16" />
                            <Vertex pos="-3 -2.75 -16" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 160 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 512 0 0.229167 0.25" texRot="0" texScale="0.229167 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.0830455 0.996546 -0 -2.49136" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.0830455 -0.996546 0 -2.49136" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -16" album="" material="bm_friction_mud" texgens="1 0 0 12288 0 -1 0 1472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -16" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 96 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="42 -6.25 -4" rot="1 0 0 0" scale="" transform="1 0 0 42 0 1 0 -6.25 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3.25 15" />
                            <Vertex pos="3 3.25 -15" />
                            <Vertex pos="3 -2.25 15" />
                            <Vertex pos="3 -2.25 -15" />
                            <Vertex pos="-2.5 2.25 15" />
                            <Vertex pos="-2.5 2.25 -15" />
                            <Vertex pos="-3 -3.25 15" />
                            <Vertex pos="-3 -3.25 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 96 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.995893 0.0905357 0 -2.69344" album="" material="bm_grid_blank4" texgens="0 -1 0 160 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.178885 0.98387 0 -2.66092" album="" material="bm_grid_blank4" texgens="-1 0 0 -93.0889 0 0 -1 640 0 0.229167 0.25" texRot="0" texScale="0.229167 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.164399 -0.986394 0 -2.71258" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_friction_mud" texgens="1 0 0 10752 0 -1 0 1600 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 160 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="37 -6.5 -4" rot="1 0 0 0" scale="" transform="1 0 0 37 0 1 0 -6.5 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.5 2.5 15" />
                            <Vertex pos="2.5 2.5 -15" />
                            <Vertex pos="2 -3 15" />
                            <Vertex pos="2 -3 -15" />
                            <Vertex pos="-2.5 3 15" />
                            <Vertex pos="-2.5 3 -15" />
                            <Vertex pos="-2.5 -2 15" />
                            <Vertex pos="-2.5 -2 -15" />
                        </Vertices>
                        <Face id="0" plane="0.995893 -0.0905357 0 -2.26339" album="" material="bm_grid_blank4" texgens="0 1 0 64 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2.5" album="" material="bm_grid_blank4" texgens="0 -1 0 192 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.0995037 0.995037 -0 -2.73635" album="" material="bm_grid_blank4" texgens="-1 0 0 -0.000732422 0 0 -1 640 0 0.3125 0.25" texRot="0" texScale="0.3125 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.21693 -0.976187 -0 -2.4947" album="" material="bm_grid_blank4" texgens="1 0 0 28.4434 0 0 -1 640 0 0.28125 0.25" texRot="0" texScale="0.28125 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -15" album="" material="bm_friction_mud" texgens="1 0 0 9472 0 -1 0 1664 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="31.75 -5.25 -4" rot="1 0 0 0" scale="" transform="1 0 0 31.75 0 1 0 -5.25 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.75 1.75 15" />
                            <Vertex pos="2.75 1.75 -15" />
                            <Vertex pos="2.75 -3.25 15" />
                            <Vertex pos="2.75 -3.25 -15" />
                            <Vertex pos="-0.249998 3.25 15" />
                            <Vertex pos="-0.249998 3.25 -15" />
                            <Vertex pos="-2.75 -0.750002 15" />
                            <Vertex pos="-2.75 -0.750002 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.75" album="" material="bm_grid_blank4" texgens="0 1 0 224 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.847998 0.529999 0 -1.93449" album="" material="bm_grid_blank4" texgens="0 -1 0 416 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.447214 0.894427 -0 -2.79509" album="" material="bm_grid_blank4" texgens="-0.86491 0.501927 0 -106.773 0 0 -1 -1664 0 0.321682 0.25" texRot="0" texScale="0.321682 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.413803 -0.910367 -0 -1.82073" album="" material="bm_grid_blank4" texgens="1 0 0 -128.005 0 0 -1 640 0 0.229167 0.25" texRot="0" texScale="0.229167 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -15" album="" material="bm_friction_mud" texgens="1 0 0 8128 0 -1 0 1344 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 416 0 -1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="26 4 -5" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 4 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 14" />
                            <Vertex pos="3 3 -14" />
                            <Vertex pos="3 -3 14" />
                            <Vertex pos="3 -3 -14" />
                            <Vertex pos="-3 3 14" />
                            <Vertex pos="-3 3 -14" />
                            <Vertex pos="-2.5 -3 14" />
                            <Vertex pos="-2.5 -3 -14" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.996546 -0.0830455 0 -2.7405" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_friction_mud" texgens="1 0 0 6656 0 -1 0 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="26.75 -0.999999 -5" rot="1 0 0 0" scale="" transform="1 0 0 26.75 0 1 0 -0.999999 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.25 2 14" />
                            <Vertex pos="2.25 2 -14" />
                            <Vertex pos="3.25 -9.53674e-007 14" />
                            <Vertex pos="3.25 -9.53674e-007 -14" />
                            <Vertex pos="-3.25 2 14" />
                            <Vertex pos="-3.25 2 -14" />
                            <Vertex pos="-1.75 -2 14" />
                            <Vertex pos="-1.75 -2 -14" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447213 0 -2.90689" album="" material="bm_grid_blank4" texgens="0 1 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.936329 -0.351123 0 -2.34082" album="" material="bm_grid_blank4" texgens="0 -1 0 -0.00012207 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 544 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.371391 -0.928477 0 -1.20702" album="" material="bm_grid_blank4" texgens="1 0 0 -288 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_friction_mud" texgens="1 0 0 6848 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 544 0 -1 0 -0.00012207 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="28.25 -3.5 -5" rot="1 0 0 0" scale="" transform="1 0 0 28.25 0 1 0 -3.5 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.74999 2.5 14" />
                            <Vertex pos="1.74999 2.5 -14" />
                            <Vertex pos="3.25 1.5 14" />
                            <Vertex pos="3.25 1.5 -14" />
                            <Vertex pos="-3.25 0.500004 14" />
                            <Vertex pos="-3.25 0.500004 -14" />
                            <Vertex pos="0.750002 -2.5 14" />
                            <Vertex pos="0.750002 -2.5 -14" />
                        </Vertices>
                        <Face id="0" plane="0.554698 0.832052 0 -3.05085" album="" material="bm_grid_blank4" texgens="-0.86491 0.501927 0 281.74 0 0 -1 -1536 0 0.321682 0.25" texRot="0" texScale="0.321682 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.6 -0.8 0 -1.55" album="" material="bm_grid_blank4" texgens="0 -1 0 -170.663 0 0 -1 768 0 0.1875 0.25" texRot="0" texScale="0.1875 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.371391 0.928477 0 -1.67126" album="" material="bm_grid_blank4" texgens="-1 0 0 352 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.847999 -0.529999 0 -1.961" album="" material="bm_grid_blank4" texgens="1 0 0 -96 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -14" album="" material="bm_friction_mud" texgens="1 0 0 7232 0 -1 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 352 0 -1 0 -192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="-18 0.5 -5.5" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 0.5 0 0 1 -5.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3.5 13.5" />
                            <Vertex pos="1 3.5 -13.5" />
                            <Vertex pos="1 -2.5 13.5" />
                            <Vertex pos="1 -2.5 -13.5" />
                            <Vertex pos="-1 2.5 12.5" />
                            <Vertex pos="-1 2.5 -13.5" />
                            <Vertex pos="-1 -3.5 12.5" />
                            <Vertex pos="-1 -3.5 -13.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 -1344 0 0 -1 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 1600 0 0 -1 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 -2.68328" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 0 -1 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.68328" album="" material="bm_grid_blank4" texgens="1 0 0 -1408 0 0 -1 2368 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -11.6276" album="" material="bm_tile02_B" texgens="1 0 0 256 0.5 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -13.5" album="" material="bm_grid_blank4" texgens="-1 0 0 1664 0 -1 0 1600 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="-25 0 -6" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 0 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6 3 13" />
                            <Vertex pos="6 3 -13" />
                            <Vertex pos="6 -3 13" />
                            <Vertex pos="6 -3 -13" />
                            <Vertex pos="-6 3 13" />
                            <Vertex pos="-6 3 -13" />
                            <Vertex pos="-6 -3 13" />
                            <Vertex pos="-6 -3 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile02_B" texgens="1 0 0 -512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 512 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="-34 0 -4" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 0 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0 15" />
                            <Vertex pos="3 0 -15" />
                            <Vertex pos="3 -3 15" />
                            <Vertex pos="3 -3 -15" />
                            <Vertex pos="-3 0 15" />
                            <Vertex pos="-3 0 -15" />
                            <Vertex pos="-3 -3 15" />
                            <Vertex pos="-3 -3 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_stripe_caution2" texgens="0 1 -1.5 1088 0 0 -1 640 0 0.75 0.75" texRot="0" texScale="0.75 0.75" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_tile02_B" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="-34 -6 -4" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -6 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 15" />
                            <Vertex pos="3 3 -15" />
                            <Vertex pos="3 -3 15" />
                            <Vertex pos="3 -3 -15" />
                            <Vertex pos="-3 3 15" />
                            <Vertex pos="-3 3 -15" />
                            <Vertex pos="-3 -3 15" />
                            <Vertex pos="-3 -3 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_tile02_B" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="-34 -9.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -9.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="-34 -14.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -14.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="-31.5 -12 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 -12 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="-36.5 -12 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -36.5 0 1 0 -12 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="-36.5 -17 10.25" rot="1 0 0 0" scale="" transform="1 0 0 -36.5 0 1 0 -17 0 0 1 10.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.75" />
                            <Vertex pos="0.5 2 0.249999" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="0.5 -2 -0.750001" />
                            <Vertex pos="-0.5 2 0.75" />
                            <Vertex pos="-0.5 2 0.249999" />
                            <Vertex pos="-0.5 -2 -0.25" />
                            <Vertex pos="-0.5 -2 -0.750001" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242537" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="-34 -19.5 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -19.5 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="-34 -24.5 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -24.5 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="-31.5 -22 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 -22 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="-36.5 -22 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -36.5 0 1 0 -22 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="-31.5 -27 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 -27 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.75" />
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="0.5 -2 -0.75" />
                            <Vertex pos="-0.5 2 0.75" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                            <Vertex pos="-0.5 -2 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.242536 0.970143 -0.242536" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.242536 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="-34 -29.5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -29.5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="-34 -34.5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 -34.5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="-36.5 -32 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -36.5 0 1 0 -32 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_trim" texgens="0 1 0 -8192 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="Blasted" material="bm_trim" texgens="0 -1 0 8192 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="-29 -34.5 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -29 0 1 0 -34.5 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="2 0.5 -0.75" />
                            <Vertex pos="2 -0.5 -0.25" />
                            <Vertex pos="2 -0.5 -0.75" />
                            <Vertex pos="-2 0.5 0.75" />
                            <Vertex pos="-2 0.5 0.25" />
                            <Vertex pos="-2 -0.5 0.75" />
                            <Vertex pos="-2 -0.5 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_tile04_B" texgens="1 0 0 -1536 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="-24 -34.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -24 0 1 0 -34.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 6144 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="Blasted" material="bm_trim" texgens="1 0 0 -6144 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="-21.5 -37 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -37 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -3 0.25" />
                            <Vertex pos="0.5 -3 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -3 0.25" />
                            <Vertex pos="-0.5 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="-26.5 -37 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -26.5 0 1 0 -37 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -3 0.25" />
                            <Vertex pos="0.5 -3 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -3 0.25" />
                            <Vertex pos="-0.5 -3 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="-19 -39.5 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 -39.5 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="2 0.5 -0.75" />
                            <Vertex pos="2 -0.5 -0.25" />
                            <Vertex pos="2 -0.5 -0.75" />
                            <Vertex pos="-2 0.5 0.75" />
                            <Vertex pos="-2 0.5 0.25" />
                            <Vertex pos="-2 -0.5 0.75" />
                            <Vertex pos="-2 -0.5 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -896 0 0 -1 192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 0.970143 -0.242536" album="" material="bm_tile04_B" texgens="1 0 0 -1536 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.242536 0 -0.970143 -0.242536" album="" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="-14 -39.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -39.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="-14 -44.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -44.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="-3 0.5 0.25" />
                            <Vertex pos="-3 0.5 -0.25" />
                            <Vertex pos="-3 -0.5 0.25" />
                            <Vertex pos="-3 -0.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 -1024 0 -1 0 256 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="-11.5 -42 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 -42 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="-16.5 -42 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -16.5 0 1 0 -42 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 2 0.25" />
                            <Vertex pos="0.5 2 -0.25" />
                            <Vertex pos="0.5 -2 0.25" />
                            <Vertex pos="0.5 -2 -0.25" />
                            <Vertex pos="-0.5 2 0.25" />
                            <Vertex pos="-0.5 2 -0.25" />
                            <Vertex pos="-0.5 -2 0.25" />
                            <Vertex pos="-0.5 -2 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="" material="bm_edge_white" texgens="0 1 0 512 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.5" album="" material="bm_edge_white" texgens="0 -1 0 -384 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_edge_white" texgens="-1 0 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_edge_white" texgens="1 0 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_tile04_B" texgens="1 0 0 256 0 -1 0 -512 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="-14 -48 -6" rot="1 0 0 0" scale="" transform="1 0 0 -14 0 1 0 -48 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 13" />
                            <Vertex pos="3 3 -13" />
                            <Vertex pos="3 -3 13" />
                            <Vertex pos="3 -3 -13" />
                            <Vertex pos="-3 3 13" />
                            <Vertex pos="-3 3 -13" />
                            <Vertex pos="-3 -3 13" />
                            <Vertex pos="-3 -3 -13" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -13" album="" material="bm_tile02_B" texgens="1 0 0 256 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -13" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="-7 -48 -9" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -48 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 10" />
                            <Vertex pos="4 3 -10" />
                            <Vertex pos="4 -3 10" />
                            <Vertex pos="4 -3 -10" />
                            <Vertex pos="-4 3 10" />
                            <Vertex pos="-4 3 -10" />
                            <Vertex pos="-4 -3 10" />
                            <Vertex pos="-4 -3 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_tile02_B" texgens="1 0 0 512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="0 -9 -11" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -9 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 12 8" />
                            <Vertex pos="3 12 -8" />
                            <Vertex pos="3 -6 8" />
                            <Vertex pos="3 -6 -8" />
                            <Vertex pos="-3 12 8" />
                            <Vertex pos="-3 12 -8" />
                            <Vertex pos="-3 -6 8" />
                            <Vertex pos="-3 -6 -8" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 -1024 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -12" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -6" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -8" album="" material="bm_tile02_B" texgens="1 0 0 256 0 -1 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -8" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="-7 -42 0" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -42 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 19" />
                            <Vertex pos="4 3 -19" />
                            <Vertex pos="4 -3 19" />
                            <Vertex pos="4 -3 -19" />
                            <Vertex pos="-4 3 19" />
                            <Vertex pos="-4 3 -19" />
                            <Vertex pos="-4 -3 19" />
                            <Vertex pos="-4 -3 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile02_B" texgens="1 0 0 512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="-7 -37 -2" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -37 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 15" />
                            <Vertex pos="4 2 -17" />
                            <Vertex pos="4 -2 17" />
                            <Vertex pos="4 -2 -17" />
                            <Vertex pos="-4 2 15" />
                            <Vertex pos="-4 2 -17" />
                            <Vertex pos="-4 -2 17" />
                            <Vertex pos="-4 -2 -17" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 -14.3108" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -17" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="-7 -33 -5" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -33 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 2 10" />
                            <Vertex pos="4 2 -14" />
                            <Vertex pos="4 -2 14" />
                            <Vertex pos="4 -2 -14" />
                            <Vertex pos="-2 2 10" />
                            <Vertex pos="-2 2 -14" />
                            <Vertex pos="-4 -2 14" />
                            <Vertex pos="-4 -2 -14" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 -2.68328" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -8.48528" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -14" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="0 -44 -9" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 -44 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 7 10" />
                            <Vertex pos="3 7 -10" />
                            <Vertex pos="3 -7 10" />
                            <Vertex pos="3 -7 -10" />
                            <Vertex pos="-3 7 10" />
                            <Vertex pos="-3 7 -10" />
                            <Vertex pos="-3 -7 10" />
                            <Vertex pos="-3 -7 -10" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 640 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -384 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -7" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -10" album="" material="bm_tile02_B" texgens="1 0 0 256 0 -1 0 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -10" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="78 -12 34" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 -12 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.999992 1 3" />
                            <Vertex pos="2.99999 3 -3" />
                            <Vertex pos="0.999992 -1 3" />
                            <Vertex pos="2.99999 -3 -3" />
                            <Vertex pos="-0.999992 1 3" />
                            <Vertex pos="-2.99999 3 -3" />
                            <Vertex pos="-0.999992 -1 3" />
                            <Vertex pos="-2.99999 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="0.948683 -0 0.316227 -1.89736" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 0 0.316227 -1.89736" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.948683 0.316228 -1.89737" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.948683 0.316228 -1.89737" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -3456 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="65 40 41" rot="1 0 0 0" scale="" transform="1 0 0 65 0 1 0 40 0 0 1 41 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.99999 5 6" />
                            <Vertex pos="5.99999 9 -6" />
                            <Vertex pos="1.99999 -3 6" />
                            <Vertex pos="5.99999 -9 -6" />
                            <Vertex pos="-2 5 6" />
                            <Vertex pos="-6 9 -6" />
                            <Vertex pos="-2 -3 6" />
                            <Vertex pos="-6 -9 -6" />
                        </Vertices>
                        <Face id="0" plane="0.948683 -0 0.316228 -3.79472" album="" material="bm_grid_blank4" texgens="0 1 0 -640 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 0 0.316228 -3.79473" album="" material="bm_grid_blank4" texgens="0 -1 0 896 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.948683 0.316228 -6.64078" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.894427 0.447214 -5.36656" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -6" album="" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -6" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="-7 -54 0" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -54 0 0 1 0 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 19" />
                            <Vertex pos="4 3 -19" />
                            <Vertex pos="4 -3 19" />
                            <Vertex pos="4 -3 -19" />
                            <Vertex pos="-4 3 19" />
                            <Vertex pos="-4 3 -19" />
                            <Vertex pos="-4 -3 19" />
                            <Vertex pos="-4 -3 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -19" album="" material="bm_tile02_B" texgens="1 0 0 512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="-7 -48 16" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -48 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 3 3" />
                            <Vertex pos="4 3 -3" />
                            <Vertex pos="4 -3 3" />
                            <Vertex pos="4 -3 -3" />
                            <Vertex pos="-4 3 3" />
                            <Vertex pos="-4 3 -3" />
                            <Vertex pos="-4 -3 3" />
                            <Vertex pos="-4 -3 -3" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_tile02_B" texgens="1 0 0 512 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="-4 -48 9" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -48 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 3 4" />
                            <Vertex pos="1 3 -4" />
                            <Vertex pos="1 -3 4" />
                            <Vertex pos="1 -3 -4" />
                            <Vertex pos="-1 3 4" />
                            <Vertex pos="-1 3 -4" />
                            <Vertex pos="-1 -3 4" />
                            <Vertex pos="-1 -3 -4" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -384 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -4" album="" material="bm_tile02_B" texgens="1 0 0 -768 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -4" album="" material="bm_grid_blank4" texgens="-1 0 0 640 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="-7 -48 22" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -48 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 5 3" />
                            <Vertex pos="4 9 -3" />
                            <Vertex pos="2 -7 3" />
                            <Vertex pos="4 -9 -3" />
                            <Vertex pos="-2 5 3" />
                            <Vertex pos="-4 9 -3" />
                            <Vertex pos="-2 -7 3" />
                            <Vertex pos="-4 -9 -3" />
                        </Vertices>
                        <Face id="0" plane="0.948683 -0 0.316228 -2.84605" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.948683 0 0.316228 -2.84605" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.83205 0.5547 -5.82435" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.948683 0.316228 -7.58947" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -256 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="-7 -49 28" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -49 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 4 3" />
                            <Vertex pos="2 6 -3" />
                            <Vertex pos="1 -2 3" />
                            <Vertex pos="2 -6 -3" />
                            <Vertex pos="-1 4 3" />
                            <Vertex pos="-2 6 -3" />
                            <Vertex pos="-1 -2 3" />
                            <Vertex pos="-2 -6 -3" />
                        </Vertices>
                        <Face id="0" plane="0.986394 -0 0.164399 -1.47959" album="" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.986394 0 0.164399 -1.47959" album="" material="bm_grid_blank4" texgens="0 -1 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 0.948683 0.316228 -4.74342" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.83205 0.5547 -3.3282" album="" material="bm_grid_blank4" texgens="1 0 0 256 0 0 -1 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="68 29 4" rot="1 0 0 0" scale="" transform="1 0 0 68 0 1 0 29 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 23" />
                            <Vertex pos="3 2 -23" />
                            <Vertex pos="3 -2 21" />
                            <Vertex pos="3 -2 -23" />
                            <Vertex pos="-3 2 23" />
                            <Vertex pos="-3 2 -23" />
                            <Vertex pos="-3 -2 21" />
                            <Vertex pos="-3 -2 -23" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -19.6774" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -23" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="68 25 -9.53674e-007" rot="1 0 0 0" scale="" transform="1 0 0 68 0 1 0 25 0 0 1 -9.53674e-007 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 19" />
                            <Vertex pos="3 2 -19" />
                            <Vertex pos="3 -2 17" />
                            <Vertex pos="3 -2 -19" />
                            <Vertex pos="-3 2 19" />
                            <Vertex pos="-3 2 -19" />
                            <Vertex pos="-3 -2 17" />
                            <Vertex pos="-3 -2 -19" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -16.0997" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -19" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="78 28 2" rot="1 0 0 0" scale="" transform="1 0 0 78 0 1 0 28 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 21" />
                            <Vertex pos="3 3 -21" />
                            <Vertex pos="3 -3 19" />
                            <Vertex pos="3 -3 -21" />
                            <Vertex pos="-3 3 21" />
                            <Vertex pos="-3 3 -21" />
                            <Vertex pos="-3 -3 19" />
                            <Vertex pos="-3 -3 -21" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 384 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 -128 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.316228 0.948683 -18.9737" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -21" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="45 34 1" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 34 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 3 20" />
                            <Vertex pos="2 3 -20" />
                            <Vertex pos="2 -3 20" />
                            <Vertex pos="2 -3 -20" />
                            <Vertex pos="-2 3 18" />
                            <Vertex pos="-2 3 -20" />
                            <Vertex pos="-2 -3 18" />
                            <Vertex pos="-2 -3 -20" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="" material="bm_grid_blank4" texgens="0 1 0 128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="" material="bm_grid_blank4" texgens="0 -1 0 128 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 0 -1 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 -16.9941" album="" material="bm_grid_blank4" texgens="1 0 0 0 0 -1 0 -128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -20" album="" material="bm_grid_blank4" texgens="-1 0 0 256 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="-6 2.5 4.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 2.5 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="0.5 2.5 4.75" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 2.5 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="0.5 8.5 4.75" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 8.5 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3.5 -0.25" />
                            <Vertex pos="2 -3.5 -0.75" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="1.5 -3.5 -0.25" />
                            <Vertex pos="1.5 -3.5 -0.75" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -0.223607" album="" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -0.223607" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.09141" album="" material="bm_edge_white" texgens="1 0.5 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.57648" album="" material="bm_edge_white" texgens="-1 -0.5 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="-6 8.5 4.75" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 8.5 0 0 1 4.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3.5 -0.25" />
                            <Vertex pos="2 -3.5 -0.75" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="1.5 -3.5 -0.25" />
                            <Vertex pos="1.5 -3.5 -0.75" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 0.447214 0 -0.223607" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 -0.447214 0 -0.223607" album="" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.25 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.09141" album="" material="bm_edge_white" texgens="1 0.5 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.57648" album="" material="bm_edge_white" texgens="-1 -0.5 0 64 0 -1 0 -896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="-7 10.5 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 10.5 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -1.5 -1.75" />
                            <Vertex pos="2 -1.5 -2.25" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="1.5 -1.5 -1.75" />
                            <Vertex pos="1.5 -1.5 -2.25" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 0.242536 0 -1.57648" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 -0.242536 0 1.09141" album="" material="bm_edge_white" texgens="0 -1 0 -1280 0 -0.5 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.23607" album="" material="bm_edge_white" texgens="1 0.25 0 -288 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.68328" album="" material="bm_edge_white" texgens="-1 -0.25 0 416 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="-0.5 10.5 4.25" rot="1 0 0 0" scale="" transform="1 0 0 -0.5 0 1 0 10.5 0 0 1 4.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -1.5 -1.75" />
                            <Vertex pos="0 -1.5 -2.25" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="-0.5 -1.5 -1.75" />
                            <Vertex pos="-0.5 -1.5 -2.25" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.8 0.6 0 0.9" album="" material="bm_edge_white" texgens="0 1 0 512 0 -0.5 -1 -640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.8 -0.6 0 -1.3" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.447214 0.894427 2.23607" album="" material="bm_edge_white" texgens="1 0.75 0 416 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.447214 -0.894427 -2.68328" album="" material="bm_edge_white" texgens="-1 -0.75 0 -288 0 -1 0 -384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="-2.5 14.5 2.25" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 14.5 0 0 1 2.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 -3.5 -0.25" />
                            <Vertex pos="2 -3.5 -0.75" />
                            <Vertex pos="2 -5.5 0.25" />
                            <Vertex pos="2 -5.5 -0.25" />
                            <Vertex pos="1.5 -3.5 -0.25" />
                            <Vertex pos="1.5 -3.5 -0.75" />
                            <Vertex pos="1.5 -5.5 0.25" />
                            <Vertex pos="1.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -2" album="" material="bm_edge_white" texgens="0 1 0 1408 0 -0.25 -1 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 1.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 3.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.242536 0.970143 1.09141" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.242536 -0.970143 -1.57648" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-8 18.5 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 18.5 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-3.5 18.5 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 18.5 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0.5 0.25" />
                            <Vertex pos="3 0.5 -0.25" />
                            <Vertex pos="3 -7.5 0.25" />
                            <Vertex pos="3 -7.5 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 -7.5 0.25" />
                            <Vertex pos="2.5 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-3.5 32.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 32.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -4 0.25" />
                            <Vertex pos="3 -4 -0.25" />
                            <Vertex pos="3 -7.5 0.25" />
                            <Vertex pos="3 -7.5 -0.25" />
                            <Vertex pos="2.5 -3.5 0.25" />
                            <Vertex pos="2.5 -3.5 -0.25" />
                            <Vertex pos="2.5 -7.5 0.25" />
                            <Vertex pos="2.5 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 0.707107" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-8 32.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 32.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -3.5 0.25" />
                            <Vertex pos="3 -3.5 -0.25" />
                            <Vertex pos="3 -7.5 0.25" />
                            <Vertex pos="3 -7.5 -0.25" />
                            <Vertex pos="2.5 -4 0.25" />
                            <Vertex pos="2.5 -4 -0.25" />
                            <Vertex pos="2.5 -7.5 0.25" />
                            <Vertex pos="2.5 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 4.59619" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="18.5 36.5 12.75" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 36.5 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="-3.5 0.5 0.25" />
                            <Vertex pos="-3.5 0.5 -0.25" />
                            <Vertex pos="-3.5 0 0.25" />
                            <Vertex pos="-3.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="18.5 43 12.75" rot="1 0 0 0" scale="" transform="1 0 0 18.5 0 1 0 43 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="-3.5 0.5 0.25" />
                            <Vertex pos="-3.5 0.5 -0.25" />
                            <Vertex pos="-3.5 0 0.25" />
                            <Vertex pos="-3.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="8.5 36.5 12.75" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 36.5 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="4.5 0.5 -0.25" />
                            <Vertex pos="4.5 0.5 -0.75" />
                            <Vertex pos="4.5 0 -0.25" />
                            <Vertex pos="4.5 0 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -1152 0.25 0 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 1.33395" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -1.81902" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="6.5 36.5 12.25" rot="1 0 0 0" scale="" transform="1 0 0 6.5 0 1 0 36.5 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="21" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="4.5 0.5 -0.75" />
                            <Vertex pos="4.5 0.5 -1.25" />
                            <Vertex pos="5 0 -0.5" />
                            <Vertex pos="5 0 -1" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 3.53553" album="" material="bm_edge_white" texgens="0 -1 0 128 0 -0.5 -1 -128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -1280 0.5 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="18" plane="-0.447214 0 0.894427 2.68328" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="19" plane="0.447214 0 -0.894427 -3.1305" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="8.5 43 12.75" rot="1 0 0 0" scale="" transform="1 0 0 8.5 0 1 0 43 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="4.5 0 -0.25" />
                            <Vertex pos="4.5 0 -0.75" />
                            <Vertex pos="4.5 -0.5 -0.25" />
                            <Vertex pos="4.5 -0.5 -0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970143 0 1.09141" album="" material="bm_edge_white" texgens="-1 0 0 1664 0.25 0 -1 -352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970143 0 -1.57648" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.242536 0 0.970143 1.33395" album="" material="bm_edge_white" texgens="1 0 0 -1152 0.25 -1 0 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.242536 0 -0.970143 -1.81902" album="" material="bm_edge_white" texgens="-1 0 0 1664 0.25 -1 0 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="6.5 42.5 12.25" rot="1 0 0 0" scale="" transform="1 0 0 6.5 0 1 0 42.5 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="21" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="5 0.125 -0.5" />
                            <Vertex pos="5 0.125 -1" />
                            <Vertex pos="4.5 -0.5 -0.75" />
                            <Vertex pos="4.5 -0.5 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.780869 0.624695 0 3.82626" album="" material="bm_edge_white" texgens="0 -1 0 25.6 0 0.4 -1 -140.8 0 0.15625 0.125" texRot="0" texScale="0.15625 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970142 0 1.09141" album="" material="bm_edge_white" texgens="-1 0 0 1664 0.5 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970143 0 -1.57648" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="18" plane="-0.447214 0 0.894427 2.68328" album="" material="bm_edge_white" texgens="1 0 0 -1152 0.25 -1 0 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="19" plane="0.447214 0 -0.894427 -3.1305" album="" material="bm_edge_white" texgens="-1 0 0 1664 0.25 -1 0 -288 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="40.5 43 12.75" rot="1 0 0 0" scale="" transform="1 0 0 40.5 0 1 0 43 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 0 0.25" />
                            <Vertex pos="2.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="72.5 4.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 72.5 0 1 0 4.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 6.5 0.25" />
                            <Vertex pos="3 6.5 -0.25" />
                            <Vertex pos="3 -7.5 0.25" />
                            <Vertex pos="3 -7.5 -0.25" />
                            <Vertex pos="2.5 6.5 0.25" />
                            <Vertex pos="2.5 6.5 -0.25" />
                            <Vertex pos="2.5 -7.5 0.25" />
                            <Vertex pos="2.5 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -6.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="66 4.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 66 0 1 0 4.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.5 -5.5 0.25" />
                            <Vertex pos="3.5 -5.5 -0.25" />
                            <Vertex pos="3 -7.5 0.25" />
                            <Vertex pos="3 -7.5 -0.25" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="2.5 -7.5 0.25" />
                            <Vertex pos="2.5 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -4.72944" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 4.24437" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 -0.25 0 -1120 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0.25 0 1248 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="66 6.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 66 0 1 0 6.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 -5.5 0.25" />
                            <Vertex pos="4.5 -5.5 -0.25" />
                            <Vertex pos="3.5 -7.5 0.25" />
                            <Vertex pos="3.5 -7.5 -0.25" />
                            <Vertex pos="4 -5.5 0.25" />
                            <Vertex pos="4 -5.5 -0.25" />
                            <Vertex pos="3 -7.5 0.25" />
                            <Vertex pos="3 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.894427 -0.447214 0 -6.4846" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.894427 0.447214 0 6.03738" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 -0.5 0 -1728 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0.5 0 1856 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="66 8.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 66 0 1 0 8.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 -5.5 0.25" />
                            <Vertex pos="5 -5.5 -0.25" />
                            <Vertex pos="4.5 -7.5 0.25" />
                            <Vertex pos="4.5 -7.5 -0.25" />
                            <Vertex pos="4.5 -5.5 0.25" />
                            <Vertex pos="4.5 -5.5 -0.25" />
                            <Vertex pos="4 -7.5 0.25" />
                            <Vertex pos="4 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.970143 -0.242536 0 -6.18466" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.970143 0.242536 0 5.69959" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 5.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 -0.25 0 -1504 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0.25 0 1632 0 -1 0 -1408 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="66 10.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 66 0 1 0 10.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 0.5 0.25" />
                            <Vertex pos="5 0.5 -0.25" />
                            <Vertex pos="5 -7.5 0.25" />
                            <Vertex pos="5 -7.5 -0.25" />
                            <Vertex pos="4.5 0.5 0.25" />
                            <Vertex pos="4.5 0.5 -0.25" />
                            <Vertex pos="4.5 -7.5 0.25" />
                            <Vertex pos="4.5 -7.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 4.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="62.5 -3 12.75" rot="1 0 0 0" scale="" transform="1 0 0 62.5 0 1 0 -3 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="-5 0.5 0.25" />
                            <Vertex pos="-5 0.5 -0.25" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.88909" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="56.5 -9.5 12.75" rot="1 0 0 0" scale="" transform="1 0 0 56.5 0 1 0 -9.5 0 0 1 12.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 0.707107" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="20 12.5 14.75" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 12.5 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -1.5 0.25" />
                            <Vertex pos="3 -1.5 -0.25" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="2.5 -1.5 0.25" />
                            <Vertex pos="2.5 -1.5 -0.25" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="26.5 12.5 14.75" rot="1 0 0 0" scale="" transform="1 0 0 26.5 0 1 0 12.5 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 3 0.25" />
                            <Vertex pos="3 3 -0.25" />
                            <Vertex pos="3 -5.5 0.25" />
                            <Vertex pos="3 -5.5 -0.25" />
                            <Vertex pos="2.5 3 0.25" />
                            <Vertex pos="2.5 3 -0.25" />
                            <Vertex pos="2.5 -5.5 0.25" />
                            <Vertex pos="2.5 -5.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -3" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -5.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="22.5 15 14.75" rot="1 0 0 0" scale="" transform="1 0 0 22.5 0 1 0 15 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="1 0.5 0.25" />
                            <Vertex pos="1 0.5 -0.25" />
                            <Vertex pos="0.5 0 0.25" />
                            <Vertex pos="0.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 0.353553" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="-5.5 15 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 15 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 0 0.25" />
                            <Vertex pos="2.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="-1.5 15 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 15 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="21" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4 0.5 -0.125" />
                            <Vertex pos="4 0.5 -0.625" />
                            <Vertex pos="4.5 0 -0.25" />
                            <Vertex pos="4.5 0 -0.75" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 0 0.25" />
                            <Vertex pos="2.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -3.18198" album="" material="bm_edge_white" texgens="0 1 0 0 0 0.25 -1 -64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 -0.25 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="18" plane="0.242536 0 0.970142 -0.848875" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="19" plane="-0.242536 0 -0.970143 0.363804" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="-1.5 9 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -1.5 0 1 0 9 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="21" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 1.5 -0.25" />
                            <Vertex pos="4.5 1.5 -0.75" />
                            <Vertex pos="4 0.75 -0.125" />
                            <Vertex pos="4 0.75 -0.625" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 0 0.25" />
                            <Vertex pos="2.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.83205 -0.5547 0 -2.91218" album="" material="bm_edge_white" texgens="0 1 0 -128 0 -0.175 -1 3.2 0 0.1875 0.125" texRot="0" texScale="0.1875 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 0.67082" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -1.11803" album="" material="bm_edge_white" texgens="1 0 0 -896 -0.25 0 -1 224 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="18" plane="0.242536 0 0.970143 -0.848875" album="" material="bm_edge_white" texgens="1 0 0 -640 0.5 -1 0 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="19" plane="-0.242536 0 -0.970142 0.363803" album="" material="bm_edge_white" texgens="-1 0 0 1152 0.5 -1 0 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="-5.5 8.5 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 8.5 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.5 0.25" />
                            <Vertex pos="4.5 0.5 -0.25" />
                            <Vertex pos="4.5 0 0.25" />
                            <Vertex pos="4.5 0 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 0 0.25" />
                            <Vertex pos="2.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="-3.5 8.5 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 8.5 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 1 0.25" />
                            <Vertex pos="4.5 1 -0.25" />
                            <Vertex pos="4.5 0.5 0.25" />
                            <Vertex pos="4.5 0.5 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 0 0.25" />
                            <Vertex pos="2.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.242536 0.970143 0 0.121268" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.242536 -0.970143 0 -0.606339" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0.25 -1 0 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 1152 0.25 -1 0 -32 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="-7.5 8.5 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 8.5 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.5 0.25" />
                            <Vertex pos="4.5 0.5 -0.25" />
                            <Vertex pos="4.5 0 0.25" />
                            <Vertex pos="4.5 0 -0.25" />
                            <Vertex pos="2.5 -0.5 -0.75" />
                            <Vertex pos="2.5 -0.5 -1.25" />
                            <Vertex pos="2.5 -1 -0.75" />
                            <Vertex pos="2.5 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 1.56525" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.01246" album="" material="bm_edge_white" texgens="1 0 0 -640 0.5 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 1.78885" album="" material="bm_edge_white" texgens="1 0 0 -640 0.5 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -2.23607" album="" material="bm_edge_white" texgens="-1 0 0 1152 0.5 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="-7.5 15 14.75" rot="1 0 0 0" scale="" transform="1 0 0 -7.5 0 1 0 15 0 0 1 14.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.5 0.25" />
                            <Vertex pos="4.5 0.5 -0.25" />
                            <Vertex pos="4.5 0 0.25" />
                            <Vertex pos="4.5 0 -0.25" />
                            <Vertex pos="2.5 -0.5 -0.75" />
                            <Vertex pos="2.5 -0.5 -1.25" />
                            <Vertex pos="2.5 -1 -0.75" />
                            <Vertex pos="2.5 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 1.56525" album="" material="bm_edge_white" texgens="-1 0 0 1152 0.5 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.01246" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 1.78885" album="" material="bm_edge_white" texgens="1 0 0 -640 0.5 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -2.23607" album="" material="bm_edge_white" texgens="-1 0 0 1152 0.5 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="-21.5 -2.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -2.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.5 0.25" />
                            <Vertex pos="4.5 0.5 -0.25" />
                            <Vertex pos="4.5 0 0.25" />
                            <Vertex pos="4.5 0 -0.25" />
                            <Vertex pos="2.5 -0.5 -0.75" />
                            <Vertex pos="2.5 -0.5 -1.25" />
                            <Vertex pos="2.5 -1 -0.75" />
                            <Vertex pos="2.5 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 1.56525" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.01246" album="" material="bm_edge_white" texgens="1 0 0 -640 0.5 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 1.78885" album="" material="bm_edge_white" texgens="1 0 0 -640 0.5 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -2.23607" album="" material="bm_edge_white" texgens="-1 0 0 1152 0.5 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-21.5 4 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 4 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.5 0.5 0.25" />
                            <Vertex pos="4.5 0.5 -0.25" />
                            <Vertex pos="4.5 0 0.25" />
                            <Vertex pos="4.5 0 -0.25" />
                            <Vertex pos="2.5 -0.5 -0.75" />
                            <Vertex pos="2.5 -0.5 -1.25" />
                            <Vertex pos="2.5 -1 -0.75" />
                            <Vertex pos="2.5 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -4.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.447214 0.894427 0 1.56525" album="" material="bm_edge_white" texgens="-1 0 0 1152 0.5 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.447214 -0.894427 0 -2.01246" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 1.78885" album="" material="bm_edge_white" texgens="1 0 0 -640 0.5 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -2.23607" album="" material="bm_edge_white" texgens="-1 0 0 1152 0.5 -1 0 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-19.5 -1.5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1 0 -1.5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.5 9.5 5.25" />
                            <Vertex pos="14.5 9.5 4.75" />
                            <Vertex pos="14.5 9 5.25" />
                            <Vertex pos="14.5 9 4.75" />
                            <Vertex pos="2.5 -0.5 -0.75" />
                            <Vertex pos="2.5 -0.5 -1.25" />
                            <Vertex pos="2.5 -1 -0.75" />
                            <Vertex pos="2.5 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -14.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.640184 0.768221 0 1.98457" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.640184 -0.768221 0 -2.36868" album="" material="bm_edge_white" texgens="1 0 0 -640 0.5 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 1.78885" album="" material="bm_edge_white" texgens="1 0 0 -640 0.833333 -1 0 -661.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -2.23607" album="" material="bm_edge_white" texgens="-1 0 0 3712 0.833333 -1 0 -661.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-19.5 5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -19.5 0 1 0 5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.5 9.5 5.25" />
                            <Vertex pos="14.5 9.5 4.75" />
                            <Vertex pos="14.5 9 5.25" />
                            <Vertex pos="14.5 9 4.75" />
                            <Vertex pos="2.5 -0.5 -0.75" />
                            <Vertex pos="2.5 -0.5 -1.25" />
                            <Vertex pos="2.5 -1 -0.75" />
                            <Vertex pos="2.5 -1 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -14.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.640184 0.768221 0 1.98457" album="" material="bm_edge_white" texgens="-1 0 0 3712 0.5 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.640184 -0.768221 0 -2.36868" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.447214 0 0.894427 1.78885" album="" material="bm_edge_white" texgens="1 0 0 -640 0.833333 -1 0 -661.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.447214 0 -0.894427 -2.23607" album="" material="bm_edge_white" texgens="-1 0 0 3712 0.833333 -1 0 -661.332 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="-25.5 3 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -25.5 0 1 0 3 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="-25.5 -3.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -25.5 0 1 0 -3.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="-32 3 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 3 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 0.25" />
                            <Vertex pos="1 0.5 -0.25" />
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -5.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="-32 3 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -32 0 1 0 3 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 3.75" />
                            <Vertex pos="1 0.5 -0.25" />
                            <Vertex pos="1 0 3.75" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="0.5 0.5 3.75" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 0 3.75" />
                            <Vertex pos="0.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="-40 4.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 4.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -1.5 0.25" />
                            <Vertex pos="3 -1.5 -0.25" />
                            <Vertex pos="3 -13.5 0.25" />
                            <Vertex pos="3 -13.5 -0.25" />
                            <Vertex pos="2.5 -1.5 0.25" />
                            <Vertex pos="2.5 -1.5 -0.25" />
                            <Vertex pos="2.5 -13.5 0.25" />
                            <Vertex pos="2.5 -13.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 1.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -13.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="-33.5 4.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 4.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -13.5 0.25" />
                            <Vertex pos="3 -13.5 -0.25" />
                            <Vertex pos="2.5 -8 0.25" />
                            <Vertex pos="2.5 -8 -0.25" />
                            <Vertex pos="2.5 -13.5 0.25" />
                            <Vertex pos="2.5 -13.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -13.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="-31.5 -3.5 7.25" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 -3.5 0 0 1 7.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 3.75" />
                            <Vertex pos="1 0.5 -0.25" />
                            <Vertex pos="1 0 3.75" />
                            <Vertex pos="1 0 -0.25" />
                            <Vertex pos="0.5 0.5 3.75" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 0 3.75" />
                            <Vertex pos="0.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="-33.5 -1 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 -1 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -8 0.375" />
                            <Vertex pos="2.625 -8 -0.125" />
                            <Vertex pos="2.625 -14.125 0.375" />
                            <Vertex pos="2.625 -14.125 -0.125" />
                            <Vertex pos="2.5 -8 0.25" />
                            <Vertex pos="2.5 -8 -0.25" />
                            <Vertex pos="2.5 -14 0.25" />
                            <Vertex pos="2.5 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -256 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 256 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="Blasted" material="bm_wood" texgens="-1 0 0 8576 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -8.13173" album="Blasted" material="bm_wood" texgens="1 0 0 -8576 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -8576 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 8576 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="-40 -1 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -1 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -14 0.25" />
                            <Vertex pos="3 -14 -0.25" />
                            <Vertex pos="2.875 -8 0.375" />
                            <Vertex pos="2.875 -8 -0.125" />
                            <Vertex pos="2.875 -14 0.375" />
                            <Vertex pos="2.875 -14 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -256 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 256 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="-35 -2 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 -2 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -12 0.25" />
                            <Vertex pos="3 -12 -0.25" />
                            <Vertex pos="2.875 -8.125 0.375" />
                            <Vertex pos="2.875 -8.125 -0.125" />
                            <Vertex pos="2.875 -11.875 0.375" />
                            <Vertex pos="2.875 -11.875 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -512 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 512 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 7.77817" album="Blasted" material="bm_wood" texgens="-1 0 0 8960 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -6.36396" album="Blasted" material="bm_wood" texgens="1 0 0 -8960 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -8960 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 8960 0 -1 0 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="-38.5 -1 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 -1 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -9.125 0.375" />
                            <Vertex pos="2.625 -9.125 -0.125" />
                            <Vertex pos="2.625 -12.875 0.375" />
                            <Vertex pos="2.625 -12.875 -0.125" />
                            <Vertex pos="2.5 -9 0.25" />
                            <Vertex pos="2.5 -9 -0.25" />
                            <Vertex pos="2.5 -13 0.25" />
                            <Vertex pos="2.5 -13 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -256 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 256 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 4.59619" album="Blasted" material="bm_wood" texgens="-1 0 0 9856 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -10.9602" album="Blasted" material="bm_wood" texgens="1 0 0 -9856 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -9856 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 9856 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="-30.5 -10.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -10.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.5 0.5 0.25" />
                            <Vertex pos="-1.5 0.5 -0.25" />
                            <Vertex pos="-1.625 0.375 0.375" />
                            <Vertex pos="-1.625 0.375 -0.125" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.375 0.375 0.375" />
                            <Vertex pos="-5.375 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 1.41421" album="Blasted" material="bm_wood" texgens="0 1 0 -2688 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.53553" album="Blasted" material="bm_wood" texgens="0 -1 0 2688 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 2688 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="-30.5 -14 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -14 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.625 0.125 0.375" />
                            <Vertex pos="-1.625 0.125 -0.125" />
                            <Vertex pos="-1.5 0 0.25" />
                            <Vertex pos="-1.5 0 -0.25" />
                            <Vertex pos="-5.375 0.125 0.375" />
                            <Vertex pos="-5.375 0.125 -0.125" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 1.06066" album="Blasted" material="bm_wood" texgens="0 1 0 -3584 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.88909" album="Blasted" material="bm_wood" texgens="0 -1 0 3584 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="-40 -7 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -7 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -12 -0.75" />
                            <Vertex pos="3 -12 -1.25" />
                            <Vertex pos="2.875 -8 0.375" />
                            <Vertex pos="2.875 -8 -0.125" />
                            <Vertex pos="2.875 -12 -0.625" />
                            <Vertex pos="2.875 -12 -1.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -1792 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 1792 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.696311 -0.174078 0.696311 -3.65563" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.696311 0.174078 -0.696311 3.30748" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 -1 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="-33.5 -11 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 -11 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -7.875 0.375" />
                            <Vertex pos="2.625 -7.875 -0.125" />
                            <Vertex pos="2.625 -14 0.375" />
                            <Vertex pos="2.625 -14 -0.125" />
                            <Vertex pos="2.5 -8 0.25" />
                            <Vertex pos="2.5 -8 -0.25" />
                            <Vertex pos="2.5 -14 0.25" />
                            <Vertex pos="2.5 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -2816 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 2816 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 7.42462" album="Blasted" material="bm_wood" texgens="-1 0 0 8576 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14" album="Blasted" material="bm_wood" texgens="1 0 0 -8576 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -8576 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 8576 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="-40 -11 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -11 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -14 0.25" />
                            <Vertex pos="3 -14 -0.25" />
                            <Vertex pos="2.875 -8 0.375" />
                            <Vertex pos="2.875 -8 -0.125" />
                            <Vertex pos="2.875 -14.125 0.375" />
                            <Vertex pos="2.875 -14.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -2816 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 2816 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -12.0208" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-33.5 -17 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 -17 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -8 0.375" />
                            <Vertex pos="2.625 -8 -0.125" />
                            <Vertex pos="2.625 -12 -0.625" />
                            <Vertex pos="2.625 -12 -1.125" />
                            <Vertex pos="2.5 -8 0.25" />
                            <Vertex pos="2.5 -8 -0.25" />
                            <Vertex pos="2.5 -12 -0.75" />
                            <Vertex pos="2.5 -12 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -4352 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 4352 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="Blasted" material="bm_wood" texgens="-1 0 0 8576 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -12" album="Blasted" material="bm_wood" texgens="1 0 0 -8576 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.696311 -0.174078 0.696311 0.174078" album="Blasted" material="bm_wood" texgens="1 0 0 -8576 0 -1 0 4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.696311 0.174078 -0.696311 -0.522233" album="Blasted" material="bm_wood" texgens="-1 0 0 8576 0 -1 0 4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-40 -21 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -21 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -10 0.25" />
                            <Vertex pos="3 -10 -0.25" />
                            <Vertex pos="2.875 -7.875 0.375" />
                            <Vertex pos="2.875 -7.875 -0.125" />
                            <Vertex pos="2.875 -10 0.375" />
                            <Vertex pos="2.875 -10 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -5376 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 5376 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 3.53553" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-31.5 -35.5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -31.5 0 1 0 -35.5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 0.375 0.375" />
                            <Vertex pos="0.5 0.375 -0.125" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.625 0.375 0.375" />
                            <Vertex pos="-5.625 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 1 0 -9088 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.24264" album="Blasted" material="bm_wood" texgens="0 -1 0 9088 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 8064 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -8064 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -8064 0 -1 0 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 8064 0 -1 0 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-33.5 -21 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -33.5 0 1 0 -21 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -8 0.375" />
                            <Vertex pos="2.625 -8 -0.125" />
                            <Vertex pos="2.625 -9.125 0.375" />
                            <Vertex pos="2.625 -9.125 -0.125" />
                            <Vertex pos="2.5 -8 0.25" />
                            <Vertex pos="2.5 -8 -0.25" />
                            <Vertex pos="2.5 -9 0.25" />
                            <Vertex pos="2.5 -9 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -5376 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 5376 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="Blasted" material="bm_wood" texgens="-1 0 0 8576 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -4.59619" album="Blasted" material="bm_wood" texgens="1 0 0 -8576 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -8576 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 8576 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-40 -25 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -40 0 1 0 -25 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -10 0.25" />
                            <Vertex pos="3 -10 -0.25" />
                            <Vertex pos="2.875 -8 0.375" />
                            <Vertex pos="2.875 -8 -0.125" />
                            <Vertex pos="2.875 -10.125 0.375" />
                            <Vertex pos="2.875 -10.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -6400 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 6400 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -9.19239" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -10240 0 -1 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 10240 0 -1 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-21.5 -34 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -34 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.5 0.125 -0.625" />
                            <Vertex pos="-3.5 0.125 -1.125" />
                            <Vertex pos="-3.5 0 -0.75" />
                            <Vertex pos="-3.5 0 -1.25" />
                            <Vertex pos="-5.5 0.125 -0.625" />
                            <Vertex pos="-5.5 0.125 -1.125" />
                            <Vertex pos="-5.5 0 -0.75" />
                            <Vertex pos="-5.5 0 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 3.5" album="Blasted" material="bm_wood" texgens="0 1 0 -8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -5.5" album="Blasted" material="bm_wood" texgens="0 -1 0 8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 5504 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="Blasted" material="bm_wood" texgens="1 0 0 -5504 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -5504 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.883883" album="Blasted" material="bm_wood" texgens="-1 0 0 5504 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="-17.5 -34 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -17.5 0 1 0 -34 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.375 0.125 -0.625" />
                            <Vertex pos="-3.375 0.125 -1.125" />
                            <Vertex pos="-3.5 0 -0.75" />
                            <Vertex pos="-3.5 0 -1.25" />
                            <Vertex pos="-5.5 0.125 -0.625" />
                            <Vertex pos="-5.5 0.125 -1.125" />
                            <Vertex pos="-5.5 0 -0.75" />
                            <Vertex pos="-5.5 0 -1.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 2.47487" album="Blasted" material="bm_wood" texgens="0 1 0 -8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -5.5" album="Blasted" material="bm_wood" texgens="0 -1 0 8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 4480 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="Blasted" material="bm_wood" texgens="1 0 0 -4480 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -4480 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.883883" album="Blasted" material="bm_wood" texgens="-1 0 0 4480 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-21.5 -40.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -40.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4.5 0.5 0.25" />
                            <Vertex pos="-4.5 0.5 -0.25" />
                            <Vertex pos="-4.375 0.375 0.375" />
                            <Vertex pos="-4.375 0.375 -0.125" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.625 0.375 0.375" />
                            <Vertex pos="-5.625 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 2.82843" album="Blasted" material="bm_wood" texgens="0 1 0 -10368 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.24264" album="Blasted" material="bm_wood" texgens="0 -1 0 10368 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 5504 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -5504 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -5504 0 -1 0 10368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 5504 0 -1 0 10368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-17.5 -40.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -17.5 0 1 0 -40.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.5 0.5 0.25" />
                            <Vertex pos="-3.5 0.5 -0.25" />
                            <Vertex pos="-3.5 0.375 0.375" />
                            <Vertex pos="-3.5 0.375 -0.125" />
                            <Vertex pos="-4.5 0.5 0.25" />
                            <Vertex pos="-4.5 0.5 -0.25" />
                            <Vertex pos="-4.625 0.375 0.375" />
                            <Vertex pos="-4.625 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 3.5" album="Blasted" material="bm_wood" texgens="0 1 0 -10368 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.53553" album="Blasted" material="bm_wood" texgens="0 -1 0 10368 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 4480 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -4480 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -4480 0 -1 0 10368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 4480 0 -1 0 10368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-30 -27 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -30 0 1 0 -27 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -13 0.25" />
                            <Vertex pos="3 -13 -0.25" />
                            <Vertex pos="2.875 -8.125 0.375" />
                            <Vertex pos="2.875 -8.125 -0.125" />
                            <Vertex pos="2.875 -13.125 0.375" />
                            <Vertex pos="2.875 -13.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -6912 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 6912 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 7.77817" album="Blasted" material="bm_wood" texgens="-1 0 0 7680 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -11.3137" album="Blasted" material="bm_wood" texgens="1 0 0 -7680 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -7680 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 7680 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-23.5 -26 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -26 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -7.875 0.375" />
                            <Vertex pos="2.625 -7.875 -0.125" />
                            <Vertex pos="2.625 -12.875 0.375" />
                            <Vertex pos="2.625 -12.875 -0.125" />
                            <Vertex pos="2.5 -8 0.25" />
                            <Vertex pos="2.5 -8 -0.25" />
                            <Vertex pos="2.5 -13 0.25" />
                            <Vertex pos="2.5 -13 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -6656 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 6656 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 7.42462" album="Blasted" material="bm_wood" texgens="-1 0 0 6016 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -10.9602" album="Blasted" material="bm_wood" texgens="1 0 0 -6016 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -6016 0 -1 0 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 6016 0 -1 0 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-11.5 -39 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -11.5 0 1 0 -39 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 0.125 -0.625" />
                            <Vertex pos="0.5 0.125 -1.125" />
                            <Vertex pos="0.5 0 -0.75" />
                            <Vertex pos="0.5 0 -1.25" />
                            <Vertex pos="-5.5 0.125 -0.625" />
                            <Vertex pos="-5.5 0.125 -1.125" />
                            <Vertex pos="-5.5 0 -0.75" />
                            <Vertex pos="-5.5 0 -1.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_wood" texgens="0 1 0 -9984 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -5.5" album="Blasted" material="bm_wood" texgens="0 -1 0 9984 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 2944 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0" album="Blasted" material="bm_wood" texgens="1 0 0 -2944 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -2944 0 -1 0 9984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.883884" album="Blasted" material="bm_wood" texgens="-1 0 0 2944 0 -1 0 9984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-20 -32 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -32 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -13 0.25" />
                            <Vertex pos="3 -13 -0.25" />
                            <Vertex pos="2.875 -8.125 0.375" />
                            <Vertex pos="2.875 -8.125 -0.125" />
                            <Vertex pos="2.875 -13 0.375" />
                            <Vertex pos="2.875 -13 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -8192 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 8192 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 7.77817" album="Blasted" material="bm_wood" texgens="-1 0 0 5120 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -13" album="Blasted" material="bm_wood" texgens="1 0 0 -5120 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -5120 0 -1 0 8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 5120 0 -1 0 8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-30.5 -15.5 10.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -15.5 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 0.5 0.25" />
                            <Vertex pos="-0.5 0.5 -0.25" />
                            <Vertex pos="-0.375 0.375 0.375" />
                            <Vertex pos="-0.375 0.375 -0.125" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.375 0.375 0.375" />
                            <Vertex pos="-5.375 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 -3968 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.53553" album="Blasted" material="bm_wood" texgens="0 -1 0 3968 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2752 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-30.5 -19 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -19 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.375 0.125 0.375" />
                            <Vertex pos="-0.375 0.125 -0.125" />
                            <Vertex pos="-0.5 0 0.25" />
                            <Vertex pos="-0.5 0 -0.25" />
                            <Vertex pos="-5.375 0.125 0.375" />
                            <Vertex pos="-5.375 0.125 -0.125" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 0.353553" album="Blasted" material="bm_wood" texgens="0 1 0 -4864 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.88909" album="Blasted" material="bm_wood" texgens="0 -1 0 4864 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-35 -12 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -35 0 1 0 -12 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -12 0.25" />
                            <Vertex pos="3 -12 -0.25" />
                            <Vertex pos="2.875 -8.125 0.375" />
                            <Vertex pos="2.875 -8.125 -0.125" />
                            <Vertex pos="2.875 -11.875 0.375" />
                            <Vertex pos="2.875 -11.875 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -3072 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 3072 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 7.77817" album="Blasted" material="bm_wood" texgens="-1 0 0 8960 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -6.36396" album="Blasted" material="bm_wood" texgens="1 0 0 -8960 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -8960 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 8960 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-38.5 -11 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 -11 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -9.125 0.375" />
                            <Vertex pos="2.625 -9.125 -0.125" />
                            <Vertex pos="2.625 -12.875 0.375" />
                            <Vertex pos="2.625 -12.875 -0.125" />
                            <Vertex pos="2.5 -9 0.25" />
                            <Vertex pos="2.5 -9 -0.25" />
                            <Vertex pos="2.5 -13 0.25" />
                            <Vertex pos="2.5 -13 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -2816 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 2816 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 4.59619" album="Blasted" material="bm_wood" texgens="-1 0 0 9856 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -10.9602" album="Blasted" material="bm_wood" texgens="1 0 0 -9856 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -9856 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 9856 0 -1 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-30.5 -20.5 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -20.5 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.5 0.5 0.25" />
                            <Vertex pos="-1.5 0.5 -0.25" />
                            <Vertex pos="-1.625 0.375 0.375" />
                            <Vertex pos="-1.625 0.375 -0.125" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.375 0.375 0.375" />
                            <Vertex pos="-5.375 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 1.41421" album="Blasted" material="bm_wood" texgens="0 1 0 -5248 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.53553" album="Blasted" material="bm_wood" texgens="0 -1 0 5248 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-30.5 -24 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -24 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.625 0.125 0.375" />
                            <Vertex pos="-1.625 0.125 -0.125" />
                            <Vertex pos="-1.5 0 0.25" />
                            <Vertex pos="-1.5 0 -0.25" />
                            <Vertex pos="-5.375 0.125 0.375" />
                            <Vertex pos="-5.375 0.125 -0.125" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 1.06066" album="Blasted" material="bm_wood" texgens="0 1 0 -6144 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.88909" album="Blasted" material="bm_wood" texgens="0 -1 0 6144 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="-38.5 -21 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 -21 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -12 0.375" />
                            <Vertex pos="2.625 -12 -0.125" />
                            <Vertex pos="2.625 -12.875 0.375" />
                            <Vertex pos="2.625 -12.875 -0.125" />
                            <Vertex pos="2.5 -12 0.25" />
                            <Vertex pos="2.5 -12 -0.25" />
                            <Vertex pos="2.5 -13 0.25" />
                            <Vertex pos="2.5 -13 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -5376 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 5376 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 12" album="Blasted" material="bm_wood" texgens="-1 0 0 9856 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -10.9602" album="Blasted" material="bm_wood" texgens="1 0 0 -9856 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -9856 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 9856 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="-30.5 -30.5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -30.5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 0.5 0.25" />
                            <Vertex pos="-0.5 0.5 -0.25" />
                            <Vertex pos="-0.375 0.375 0.375" />
                            <Vertex pos="-0.375 0.375 -0.125" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.375 0.375 0.375" />
                            <Vertex pos="-5.375 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 -0" album="Blasted" material="bm_wood" texgens="0 1 0 -7808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.53553" album="Blasted" material="bm_wood" texgens="0 -1 0 7808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="-30.5 -34 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -34 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 0.125 0.375" />
                            <Vertex pos="-0.5 0.125 -0.125" />
                            <Vertex pos="-0.5 0 0.25" />
                            <Vertex pos="-0.5 0 -0.25" />
                            <Vertex pos="-5.375 0.125 0.375" />
                            <Vertex pos="-5.375 0.125 -0.125" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 0.5" album="Blasted" material="bm_wood" texgens="0 1 0 -8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.88909" album="Blasted" material="bm_wood" texgens="0 -1 0 8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="-38.5 -18 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -38.5 0 1 0 -18 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -12.125 0.375" />
                            <Vertex pos="2.625 -12.125 -0.125" />
                            <Vertex pos="2.625 -13 0.375" />
                            <Vertex pos="2.625 -13 -0.125" />
                            <Vertex pos="2.5 -12 0.25" />
                            <Vertex pos="2.5 -12 -0.25" />
                            <Vertex pos="2.5 -13 0.25" />
                            <Vertex pos="2.5 -13 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -4608 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 4608 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 6.71751" album="Blasted" material="bm_wood" texgens="-1 0 0 9856 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -13" album="Blasted" material="bm_wood" texgens="1 0 0 -9856 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -9856 0 -1 0 4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 9856 0 -1 0 4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="-30.5 -25.5 9.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -25.5 0 0 1 9.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.5 0.5 0.25" />
                            <Vertex pos="-1.5 0.5 -0.25" />
                            <Vertex pos="-1.625 0.375 0.375" />
                            <Vertex pos="-1.625 0.375 -0.125" />
                            <Vertex pos="-6.5 0.5 0.25" />
                            <Vertex pos="-6.5 0.5 -0.25" />
                            <Vertex pos="-6.625 0.375 0.375" />
                            <Vertex pos="-6.625 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 1.41421" album="Blasted" material="bm_wood" texgens="0 1 0 -6528 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -4.94975" album="Blasted" material="bm_wood" texgens="0 -1 0 6528 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2496 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 6528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 6528 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="-30.5 -29 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -30.5 0 1 0 -29 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.625 0.125 0.375" />
                            <Vertex pos="-1.625 0.125 -0.125" />
                            <Vertex pos="-1.5 0 0.25" />
                            <Vertex pos="-1.5 0 -0.25" />
                            <Vertex pos="-6.625 0.125 0.375" />
                            <Vertex pos="-6.625 0.125 -0.125" />
                            <Vertex pos="-6.5 0 0.25" />
                            <Vertex pos="-6.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 1.06066" album="Blasted" material="bm_wood" texgens="0 1 0 -7424 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -4.59619" album="Blasted" material="bm_wood" texgens="0 -1 0 7424 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="1 0 0 -7808 0 -1 0 7424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 7808 0 -1 0 7424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="-25 -27 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -25 0 1 0 -27 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -13 0.25" />
                            <Vertex pos="3 -13 -0.25" />
                            <Vertex pos="2.875 -8.125 0.375" />
                            <Vertex pos="2.875 -8.125 -0.125" />
                            <Vertex pos="2.875 -13.125 0.375" />
                            <Vertex pos="2.875 -13.125 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -6912 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 6912 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 7.77817" album="Blasted" material="bm_wood" texgens="-1 0 0 6400 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -11.3137" album="Blasted" material="bm_wood" texgens="1 0 0 -6400 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -6400 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 6400 0 -1 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-28.5 -26 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -28.5 0 1 0 -26 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -9.125 0.375" />
                            <Vertex pos="2.625 -9.125 -0.125" />
                            <Vertex pos="2.625 -14.125 0.375" />
                            <Vertex pos="2.625 -14.125 -0.125" />
                            <Vertex pos="2.5 -9 0.25" />
                            <Vertex pos="2.5 -9 -0.25" />
                            <Vertex pos="2.5 -14 0.25" />
                            <Vertex pos="2.5 -14 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -6656 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 6656 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 4.59619" album="Blasted" material="bm_wood" texgens="-1 0 0 7296 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -8.13173" album="Blasted" material="bm_wood" texgens="1 0 0 -7296 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -7296 0 -1 0 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 7296 0 -1 0 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="-18.5 -35.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 -35.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.5 0.5 0.25" />
                            <Vertex pos="-3.5 0.5 -0.25" />
                            <Vertex pos="-3.625 0.375 0.375" />
                            <Vertex pos="-3.625 0.375 -0.125" />
                            <Vertex pos="-4.5 0.5 0.25" />
                            <Vertex pos="-4.5 0.5 -0.25" />
                            <Vertex pos="-4.5 0.375 0.375" />
                            <Vertex pos="-4.5 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 2.82843" album="Blasted" material="bm_wood" texgens="0 1 0 -9088 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -4.5" album="Blasted" material="bm_wood" texgens="0 -1 0 9088 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 4736 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -4736 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -4736 0 -1 0 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 4736 0 -1 0 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="-21.5 -35.5 7.75" rot="1 0 0 0" scale="" transform="1 0 0 -21.5 0 1 0 -35.5 0 0 1 7.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.5 0.5 0.25" />
                            <Vertex pos="-3.5 0.5 -0.25" />
                            <Vertex pos="-3.5 0.375 0.375" />
                            <Vertex pos="-3.5 0.375 -0.125" />
                            <Vertex pos="-4.5 0.5 0.25" />
                            <Vertex pos="-4.5 0.5 -0.25" />
                            <Vertex pos="-4.375 0.375 0.375" />
                            <Vertex pos="-4.375 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 0 0 3.5" album="Blasted" material="bm_wood" texgens="0 1 0 -9088 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -2.82843" album="Blasted" material="bm_wood" texgens="0 -1 0 9088 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 5504 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -5504 0 0 -1 -1984 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -5504 0 -1 0 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 5504 0 -1 0 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="-15 -32 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -32 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -12 0.25" />
                            <Vertex pos="3 -12 -0.25" />
                            <Vertex pos="2.875 -8.125 0.375" />
                            <Vertex pos="2.875 -8.125 -0.125" />
                            <Vertex pos="2.875 -11.875 0.375" />
                            <Vertex pos="2.875 -11.875 -0.125" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_wood" texgens="0 1 0 -8192 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.875" album="Blasted" material="bm_wood" texgens="0 -1 0 8192 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="-0.707107 0.707107 0 7.77817" album="Blasted" material="bm_wood" texgens="-1 0 0 3840 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="-0.707107 -0.707107 -0 -6.36396" album="Blasted" material="bm_wood" texgens="1 0 0 -3840 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 0.707107 -2.2981" album="Blasted" material="bm_wood" texgens="1 0 0 -3840 0 -1 0 8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 3840 0 -1 0 8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="-18.5 -31 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -18.5 0 1 0 -31 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.625 -9.125 0.375" />
                            <Vertex pos="2.625 -9.125 -0.125" />
                            <Vertex pos="2.625 -12.875 0.375" />
                            <Vertex pos="2.625 -12.875 -0.125" />
                            <Vertex pos="2.5 -9 0.25" />
                            <Vertex pos="2.5 -9 -0.25" />
                            <Vertex pos="2.5 -13 0.25" />
                            <Vertex pos="2.5 -13 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2.625" album="Blasted" material="bm_wood" texgens="0 1 0 -7936 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_wood" texgens="0 -1 0 7936 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0.707107 0.707107 -0 4.59619" album="Blasted" material="bm_wood" texgens="-1 0 0 4736 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0.707107 -0.707107 0 -10.9602" album="Blasted" material="bm_wood" texgens="1 0 0 -4736 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0.707107 0 0.707107 1.59099" album="Blasted" material="bm_wood" texgens="1 0 0 -4736 0 -1 0 7936 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_wood" texgens="-1 0 0 4736 0 -1 0 7936 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="-10.5 -40.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 -40.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.5 0.5 0.25" />
                            <Vertex pos="-1.5 0.5 -0.25" />
                            <Vertex pos="-1.625 0.375 0.375" />
                            <Vertex pos="-1.625 0.375 -0.125" />
                            <Vertex pos="-5.5 0.5 0.25" />
                            <Vertex pos="-5.5 0.5 -0.25" />
                            <Vertex pos="-5.375 0.375 0.375" />
                            <Vertex pos="-5.375 0.375 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 1.41421" album="Blasted" material="bm_wood" texgens="0 1 0 -10368 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -3.53553" album="Blasted" material="bm_wood" texgens="0 -1 0 10368 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_wood" texgens="-1 0 0 2688 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.375" album="Blasted" material="bm_wood" texgens="1 0 0 -2688 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -0.53033" album="Blasted" material="bm_wood" texgens="1 0 0 -2688 0 -1 0 10368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0 -0.707107 -0.707107 0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 2688 0 -1 0 10368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="-10.5 -44 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -10.5 0 1 0 -44 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.625 0.125 0.375" />
                            <Vertex pos="-1.625 0.125 -0.125" />
                            <Vertex pos="-1.5 0 0.25" />
                            <Vertex pos="-1.5 0 -0.25" />
                            <Vertex pos="-5.375 0.125 0.375" />
                            <Vertex pos="-5.375 0.125 -0.125" />
                            <Vertex pos="-5.5 0 0.25" />
                            <Vertex pos="-5.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="0.707107 0.707107 0 1.06066" album="Blasted" material="bm_wood" texgens="0 1 0 -11264 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.88909" album="Blasted" material="bm_wood" texgens="0 -1 0 11264 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 2688 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -2688 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.707107 0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="1 0 0 -2688 0 -1 0 11264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 -0.176777" album="Blasted" material="bm_wood" texgens="-1 0 0 2688 0 -1 0 11264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="-20 -37 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -20 0 1 0 -37 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -8 0.25" />
                            <Vertex pos="3 -8 -0.25" />
                            <Vertex pos="3 -14.5 0.25" />
                            <Vertex pos="3 -14.5 -0.25" />
                            <Vertex pos="2.5 -8 0.25" />
                            <Vertex pos="2.5 -8 -0.25" />
                            <Vertex pos="2.5 -14.5 0.25" />
                            <Vertex pos="2.5 -14.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 8" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="-17.5 -51.5 6.75" rot="1 0 0 0" scale="" transform="1 0 0 -17.5 0 1 0 -51.5 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.5 0.5 0.25" />
                            <Vertex pos="6.5 0.5 -0.25" />
                            <Vertex pos="6.5 0 0.25" />
                            <Vertex pos="6.5 0 -0.25" />
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 0 0.25" />
                            <Vertex pos="0.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -6.5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="-3.5 -51.5 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -3.5 0 1 0 -51.5 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 0.25" />
                            <Vertex pos="7 0.5 -0.25" />
                            <Vertex pos="7 0 0.25" />
                            <Vertex pos="7 0 -0.25" />
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0.5 -0.25" />
                            <Vertex pos="0.5 0 0.25" />
                            <Vertex pos="0.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="0.5 -36.5 0.75" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -36.5 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="3 -14.5 0.25" />
                            <Vertex pos="3 -14.5 -0.25" />
                            <Vertex pos="2.5 -0.5 0.25" />
                            <Vertex pos="2.5 -0.5 -0.25" />
                            <Vertex pos="2.5 -14.5 0.25" />
                            <Vertex pos="2.5 -14.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -14.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="0.5 -4.5 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 0.5 0 1 0 -4.5 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="3 -10.5 0.25" />
                            <Vertex pos="3 -10.5 -0.25" />
                            <Vertex pos="2.5 -0.5 0.25" />
                            <Vertex pos="2.5 -0.5 -0.25" />
                            <Vertex pos="2.5 -10.5 0.25" />
                            <Vertex pos="2.5 -10.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="-6 -4.5 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -4.5 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -0.5 0.25" />
                            <Vertex pos="3 -0.5 -0.25" />
                            <Vertex pos="3 -10.5 0.25" />
                            <Vertex pos="3 -10.5 -0.25" />
                            <Vertex pos="2.5 -0.5 0.25" />
                            <Vertex pos="2.5 -0.5 -0.25" />
                            <Vertex pos="2.5 -10.5 0.25" />
                            <Vertex pos="2.5 -10.5 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -10.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="2.5 -3 0.75" rot="1 0 0 0" scale="" transform="1 0 0 2.5 0 1 0 -3 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 3.75" />
                            <Vertex pos="1 0.5 -1.75" />
                            <Vertex pos="1 0 3.75" />
                            <Vertex pos="1 0 -1.75" />
                            <Vertex pos="0.5 0.5 3.75" />
                            <Vertex pos="0.5 0.5 -1.75" />
                            <Vertex pos="0.5 0 3.75" />
                            <Vertex pos="0.5 0 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="-4 -3 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -4 0 1 0 -3 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 3.75" />
                            <Vertex pos="1 0.5 -1.75" />
                            <Vertex pos="1 0 3.75" />
                            <Vertex pos="1 0 -1.75" />
                            <Vertex pos="0.5 0.5 3.75" />
                            <Vertex pos="0.5 0.5 -1.75" />
                            <Vertex pos="0.5 0 3.75" />
                            <Vertex pos="0.5 0 -1.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -1.75" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="408" owner="0" type="0" pos="28.5 7 10.75" rot="1 0 0 0" scale="" transform="1 0 0 28.5 0 1 0 7 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 3.75" />
                            <Vertex pos="1 0.5 0.75" />
                            <Vertex pos="1 0 3.75" />
                            <Vertex pos="1 0 0.75" />
                            <Vertex pos="0.5 0.5 3.75" />
                            <Vertex pos="0.5 0.5 0.25" />
                            <Vertex pos="0.5 0 3.75" />
                            <Vertex pos="0.5 0 0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="409" owner="0" type="0" pos="22 7 10.75" rot="1 0 0 0" scale="" transform="1 0 0 22 0 1 0 7 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 0.5 3.75" />
                            <Vertex pos="1 0.5 0.25" />
                            <Vertex pos="1 0 3.75" />
                            <Vertex pos="1 0 0.25" />
                            <Vertex pos="0.5 0.5 3.75" />
                            <Vertex pos="0.5 0.5 0.75" />
                            <Vertex pos="0.5 0 3.75" />
                            <Vertex pos="0.5 0 0.75" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -1" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 0.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -3.75" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 0.883883" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="435" owner="0" type="0" pos="2 -2.03407 -1.51764" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 2 0 1 0 -2.03407 -1 0 5.96046e-008 -1.51764 0 0 0 1" group="-1" locked="0" nextFaceID="660" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-1.19209e-006 -1.03407 -5" />
                            <Vertex pos="-0.51764 -0.965925 -5" />
                            <Vertex pos="-0.51764 -0.965925 1" />
                            <Vertex pos="-9.53674e-007 -1.03407 1" />
                            <Vertex pos="0.0182598 -0.965925 1" />
                            <Vertex pos="0.0182595 -0.965925 -5" />
                        </Vertices>
                        <Face id="654" plane="-0.13052 -0.991446 0 -1.02522" album="" material="bm_tile02_B" texgens="0 0 1 256 0.707105 -0.707108 0 -57.3808 0 0.125 0.176777" texRot="0" texScale="0.125 0.176777" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 379.638 1 0 0 66.258 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="656" plane="-0 0 -1 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 -123.638 1 0 0 66.257 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="657" plane="0.965921 -0.258837 -3.83818e-008 -0.267654" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0 1 0 94.9096 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="658" plane="0 1 0 0.965925" album="" material="bm_grid_blank4" texgens="-1 0 0 16.5644 0 0 1 30.6452 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="437" owner="0" type="0" pos="2 -2.20213 -2.25882" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 2 0 1 0 -2.20213 -1 0 5.96046e-008 -2.25882 0 0 0 1" group="-1" locked="0" nextFaceID="661" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.258821 -1.06583 -5" />
                            <Vertex pos="-0.741185 -0.866023 -5" />
                            <Vertex pos="-0.741184 -0.866023 1" />
                            <Vertex pos="-0.258821 -1.06583 1" />
                            <Vertex pos="-0.722924 -0.797875 1" />
                            <Vertex pos="-0.104118 -0.797875 1" />
                            <Vertex pos="-0.104118 -0.797875 -5" />
                            <Vertex pos="-0.722924 -0.797875 -5" />
                        </Vertices>
                        <Face id="654" plane="-0.382692 -0.923876 6.4629e-008 -1.08374" album="" material="bm_tile02_B" texgens="0 0 1 256 0.707105 -0.707108 0 59.001 0 0.125 0.176777" texRot="0" texScale="0.125 0.176777" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 358.128 1 0 0 161.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="656" plane="-0 0 -1 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 -102.128 1 0 0 161.129 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="657" plane="-0.965923 0.25883 0 -0.491775" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.25882 0.965926 0 96.9071 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="658" plane="0.866027 -0.499998 0 -0.308767" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.25882 0.965926 0 96.9071 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="659" plane="0 1 -0 0.797875" album="" material="bm_grid_blank4" texgens="-1 0 0 15.7371 0 0 1 28.7728 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="439" owner="0" type="0" pos="2 -2.56084 -2.91421" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 2 0 1 0 -2.56084 -1 0 5.96046e-008 -2.91421 0 0 0 1" group="-1" locked="0" nextFaceID="661" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -1.02494 -5" />
                            <Vertex pos="-0.914214 -0.707108 -5" />
                            <Vertex pos="-0.914213 -0.707108 1" />
                            <Vertex pos="-0.5 -1.02494 1" />
                            <Vertex pos="-0.75951 -0.439156 1" />
                            <Vertex pos="0.0857902 -0.439156 1" />
                            <Vertex pos="0.0857897 -0.439156 -5" />
                            <Vertex pos="-0.759511 -0.439156 -5" />
                        </Vertices>
                        <Face id="654" plane="-0.608755 -0.793359 1.02806e-007 -1.11752" album="" material="bm_tile02_B" texgens="0 0 1 256 0.707105 -0.707108 0 188.807 0 0.125 0.176777" texRot="0" texScale="0.125 0.176777" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 312.212 1 0 0 245.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="656" plane="-0 0 -1 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 -56.2119 1 0 0 245.019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="657" plane="-0.866024 0.500002 1.46254e-007 -0.438175" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.500002 0.866024 0 98.2234 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="658" plane="0.707103 -0.707111 0 -0.371194" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.500002 0.866024 0 98.2234 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="659" plane="0 1 -0 0.439156" album="" material="bm_grid_blank4" texgens="-1 0 0 14.0216 0 0 1 27.6917 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="442" owner="0" type="0" pos="2 -3.74119 -3.79788" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 2 0 1 0 -3.74119 -1 0 5.96046e-008 -3.79788 0 0 0 1" group="-1" locked="0" nextFaceID="661" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.866031 -0.74118 -5" />
                            <Vertex pos="-1.06583 -0.258817 -5" />
                            <Vertex pos="-1.06583 -0.258817 1" />
                            <Vertex pos="-0.866031 -0.74118 1" />
                            <Vertex pos="-0.797882 -0.104118 1" />
                            <Vertex pos="-0.797882 -0.72292 1" />
                            <Vertex pos="-0.797883 -0.72292 -5" />
                            <Vertex pos="-0.797883 -0.104118 -5" />
                        </Vertices>
                        <Face id="654" plane="-0.923881 -0.38268 0 -1.08374" album="" material="bm_tile02_B" texgens="0 0 1 256 0.707105 -0.707108 0 453.001 0 0.125 0.176777" texRot="0" texScale="0.125 0.176777" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 161.128 1 0 0 358.129 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="656" plane="-0 0 -1 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 94.8725 1 0 0 358.128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="657" plane="-0.499999 0.866026 7.94727e-008 -0.308772" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.866027 0.499997 0 97.6782 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="658" plane="0.258813 -0.965927 0 -0.491786" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.866027 0.499997 0 97.6782 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="659" plane="1 0 -1.58946e-007 0.797882" album="" material="bm_grid_blank4" texgens="0 -1 0 9.88066 0 0 1 28.7728 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="444" owner="0" type="0" pos="2 -4.48237 -3.96592" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 2 0 1 0 -4.48237 -1 0 5.96046e-008 -3.96592 0 0 0 1" group="-1" locked="0" nextFaceID="660" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.965926 -0.51763 -5" />
                            <Vertex pos="-1.03408 -1.43051e-006 -5" />
                            <Vertex pos="-1.03408 -1.2517e-006 1" />
                            <Vertex pos="-0.965925 -0.51763 1" />
                            <Vertex pos="-0.965927 0.0182588 1" />
                            <Vertex pos="-0.965928 0.0182586 -5" />
                        </Vertices>
                        <Face id="654" plane="-0.991443 -0.130539 3.89029e-009 -1.02523" album="" material="bm_tile02_B" texgens="0 0 1 256 0.707105 -0.707108 0 569.381 0 0.125 0.176777" texRot="0" texScale="0.125 0.176777" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 66.2566 1 0 0 379.639 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="656" plane="0 -0 -1 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 189.743 1 0 0 379.638 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="657" plane="-0.258803 0.96593 1.13212e-008 -0.267621" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.965927 0.258815 0 95.9629 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 5 4 2" />
                        </Face>
                        <Face id="658" plane="1 3.78168e-006 -1.6888e-007 0.965927" album="" material="bm_grid_blank4" texgens="0 -1 0 8.56426 0 0 1 30.6453 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 0 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="448" owner="0" type="0" pos="2 -3.08579 -3.43916" rot="0 -1 0 1.5708" scale="" transform="5.96046e-008 0 1 2 0 1 0 -3.08579 -1 0 5.96046e-008 -3.43916 0 0 0 1" group="-1" locked="0" nextFaceID="667" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.707112 -0.914213 -5" />
                            <Vertex pos="-1.02495 -0.499993 -5" />
                            <Vertex pos="-1.02495 -0.499993 1" />
                            <Vertex pos="-0.707111 -0.914213 1" />
                            <Vertex pos="-0.439156 0.0857947 -5" />
                            <Vertex pos="-0.439155 0.0857946 1" />
                            <Vertex pos="-0.439164 -0.759515 1" />
                            <Vertex pos="-0.439165 -0.759515 -5" />
                        </Vertices>
                        <Face id="660" plane="-0.793357 -0.608756 0 -1.11753" album="" material="bm_tile02_B" texgens="0 0 1 256 0.707105 -0.707108 0 323.194 0 0.125 0.176777" texRot="0" texScale="0.125 0.176777" texDiv="512 512">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="661" plane="-0.707103 0.707111 1.28196e-007 -0.371194" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.707108 0.707106 0 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="662" plane="0.499997 -0.866027 -8.44394e-008 -0.43818" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.707108 0.707106 0 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="663" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 245.018 1 0 0 312.213 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="664" plane="-0 0 -1 -5" album="" material="bm_grid_blank4" texgens="0 -1 0 10.9818 1 0 0 312.212 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="665" plane="1 -1.06473e-005 -1.63913e-007 0.439156" album="" material="bm_grid_blank4" texgens="0 -1 0 32 0 0 1 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="451" owner="0" type="0" pos="73.5176 43.9659 16" rot="1 0 0 0" scale="" transform="1 0 0 73.5176 0 1 0 43.9659 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="660" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0 -1.03407 -6" />
                            <Vertex pos="-0.517639 -0.965923 -6" />
                            <Vertex pos="-0.51764 -0.965925 1" />
                            <Vertex pos="-9.53674e-007 -1.03407 1" />
                            <Vertex pos="0.0182598 -0.965925 1" />
                            <Vertex pos="0.0182571 -0.965927 -6" />
                        </Vertices>
                        <Face id="654" plane="-0.130523 -0.991445 -2.97483e-007 -1.02523" album="" material="bm_grid_blank4" texgens="0 0 1 128 0.707105 -0.707108 0 -28.6904 0 0.25 0.353551" texRot="0" texScale="0.25 0.353551" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 379.638 1 0 0 66.258 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="656" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -123.638 1 0 0 66.257 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="657" plane="0.965921 -0.258837 1.31596e-007 -0.267655" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0 1 0 94.9096 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="658" plane="0 1 -2.89508e-007 0.965925" album="" material="bm_grid_blank4" texgens="-1 0 0 16.5644 0 0 1 30.6452 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 4 2 1" />
                        </Face>
                    </Brush>
                    <Brush id="452" owner="0" type="0" pos="74.2588 43.7979 16" rot="1 0 0 0" scale="" transform="1 0 0 74.2588 0 1 0 43.7979 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="661" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25882 -1.06583 -6" />
                            <Vertex pos="-0.741188 -0.866024 -6" />
                            <Vertex pos="-0.741184 -0.866023 1" />
                            <Vertex pos="-0.258821 -1.06583 1" />
                            <Vertex pos="-0.722924 -0.797875 1" />
                            <Vertex pos="-0.104118 -0.797875 1" />
                            <Vertex pos="-0.104118 -0.797874 -6" />
                            <Vertex pos="-0.722923 -0.797874 -6" />
                        </Vertices>
                        <Face id="654" plane="-0.382688 -0.923878 3.52059e-007 -1.08374" album="" material="bm_grid_blank4" texgens="0 0 1 128 0.707105 -0.707108 0 29.5005 0 0.25 0.353551" texRot="0" texScale="0.25 0.353551" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 358.128 1 0 0 161.13 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="656" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -102.128 1 0 0 161.129 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="657" plane="-0.965911 0.258875 -1.02346e-007 -0.49173" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.25882 0.965926 0 96.9071 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="658" plane="0.866027 -0.499998 1.25361e-007 -0.308767" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.25882 0.965926 0 96.9071 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="659" plane="0 1 1.44754e-007 0.797875" album="" material="bm_grid_blank4" texgens="-1 0 0 15.7371 0 0 1 28.7728 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="453" owner="0" type="0" pos="74.9142 43.4392 16" rot="1 0 0 0" scale="" transform="1 0 0 74.9142 0 1 0 43.4392 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="661" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.5 -1.02494 -6" />
                            <Vertex pos="-0.914215 -0.707108 -6" />
                            <Vertex pos="-0.914213 -0.707108 1" />
                            <Vertex pos="-0.5 -1.02494 1" />
                            <Vertex pos="-0.75951 -0.439156 1" />
                            <Vertex pos="0.0857902 -0.439156 1" />
                            <Vertex pos="0.0857925 -0.439156 -6" />
                            <Vertex pos="-0.759514 -0.439156 -6" />
                        </Vertices>
                        <Face id="654" plane="-0.608754 -0.793359 1.76239e-007 -1.11752" album="" material="bm_grid_blank4" texgens="0 0 1 128 0.707105 -0.707108 0 94.4045 0 0.25 0.353551" texRot="0" texScale="0.25 0.353551" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 312.212 1 0 0 245.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="656" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 -56.2119 1 0 0 245.019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="657" plane="-0.866027 0.499997 4.9407e-007 -0.43818" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.500002 0.866024 0 98.2234 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="658" plane="0.707103 -0.70711 0 -0.371194" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.500002 0.866024 0 98.2234 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="659" plane="0 1 0 0.439156" album="" material="bm_grid_blank4" texgens="-1 0 0 14.0216 0 0 1 27.6917 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="454" owner="0" type="0" pos="75.7979 42.2588 16" rot="1 0 0 0" scale="" transform="1 0 0 75.7979 0 1 0 42.2588 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="661" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.866028 -0.74118 -6" />
                            <Vertex pos="-1.06583 -0.258816 -6" />
                            <Vertex pos="-1.06583 -0.258817 1" />
                            <Vertex pos="-0.866031 -0.74118 1" />
                            <Vertex pos="-0.797882 -0.104118 1" />
                            <Vertex pos="-0.797882 -0.72292 1" />
                            <Vertex pos="-0.797882 -0.722919 -6" />
                            <Vertex pos="-0.797882 -0.104118 -6" />
                        </Vertices>
                        <Face id="654" plane="-0.923879 -0.382684 -5.37658e-008 -1.08374" album="" material="bm_grid_blank4" texgens="0 0 1 128 0.707105 -0.707108 0 226.501 0 0.25 0.353551" texRot="0" texScale="0.25 0.353551" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 161.128 1 0 0 358.129 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="656" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 94.8725 1 0 0 358.128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="657" plane="-0.499996 0.866028 0 -0.308768" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.866027 0.499997 0 97.6782 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="658" plane="0.258813 -0.965927 1.10189e-007 -0.491786" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.866027 0.499997 0 97.6782 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="659" plane="1 0 -0 0.797882" album="" material="bm_grid_blank4" texgens="0 -1 0 9.88066 0 0 1 28.7728 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="455" owner="0" type="0" pos="75.9659 41.5176 16" rot="1 0 0 0" scale="" transform="1 0 0 75.9659 0 1 0 41.5176 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="660" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.965927 -0.517632 -6" />
                            <Vertex pos="-1.03407 0 -6" />
                            <Vertex pos="-1.03408 -1.2517e-006 1" />
                            <Vertex pos="-0.965925 -0.51763 1" />
                            <Vertex pos="-0.965927 0.0182588 1" />
                            <Vertex pos="-0.965927 0.0182571 -6" />
                        </Vertices>
                        <Face id="654" plane="-0.991446 -0.130518 -1.44161e-006 -1.02523" album="" material="bm_grid_blank4" texgens="0 0 1 128 0.707105 -0.707108 0 284.692 0 0.25 0.353551" texRot="0" texScale="0.25 0.353551" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="655" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 66.2566 1 0 0 379.639 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 4" />
                        </Face>
                        <Face id="656" plane="0 -0 -1 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 189.743 1 0 0 379.638 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 5 1" />
                        </Face>
                        <Face id="657" plane="-0.258796 0.965932 -2.34666e-007 -0.267614" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.965927 0.258815 0 95.9629 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 5 4 2" />
                        </Face>
                        <Face id="658" plane="1 0 -2.89508e-007 0.965925" album="" material="bm_grid_blank4" texgens="0 -1 0 8.56426 0 0 1 30.6453 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 5 0 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="456" owner="0" type="0" pos="75.4392 42.9142 16" rot="1 0 0 0" scale="" transform="1 0 0 75.4392 0 1 0 42.9142 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="667" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.707115 -0.914211 -6" />
                            <Vertex pos="-1.02495 -0.499992 -6" />
                            <Vertex pos="-1.02495 -0.499993 1" />
                            <Vertex pos="-0.707111 -0.914213 1" />
                            <Vertex pos="-0.439156 0.0857964 -6" />
                            <Vertex pos="-0.439155 0.0857946 1" />
                            <Vertex pos="-0.439164 -0.759515 1" />
                            <Vertex pos="-0.439163 -0.759514 -6" />
                        </Vertices>
                        <Face id="660" plane="-0.793359 -0.608754 -8.55279e-008 -1.11753" album="" material="bm_grid_blank4" texgens="0 0 1 128 0.707105 -0.707108 0 161.598 0 0.25 0.353551" texRot="0" texScale="0.25 0.353551" texDiv="256 256">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="661" plane="-0.707103 0.70711 2.81481e-007 -0.371195" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.707108 0.707106 0 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="662" plane="0.499997 -0.866027 -5.35971e-007 -0.438179" album="" material="bm_grid_blank4" texgens="0 0 -1 32 0.707108 0.707106 0 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="663" plane="-0 0 1 -1" album="" material="bm_grid_blank4" texgens="0 1 0 245.018 1 0 0 312.213 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="664" plane="-0 0 -1 -6" album="" material="bm_grid_blank4" texgens="0 -1 0 10.9818 1 0 0 312.212 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="665" plane="1 -1.06473e-005 1.44753e-007 0.439156" album="" material="bm_grid_blank4" texgens="0 -1 0 32 0 0 1 98.5055 0 1 1" texRot="0" texScale="1 1" texDiv="256 256">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="457" owner="0" type="0" pos="72 29 -2" rot="1 0 0 0" scale="" transform="1 0 0 72 0 1 0 29 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2 23" />
                            <Vertex pos="3 2 17" />
                            <Vertex pos="3 -2 21" />
                            <Vertex pos="3 -2 17" />
                            <Vertex pos="-1 2 23" />
                            <Vertex pos="-1 2 17" />
                            <Vertex pos="-1 -2 21" />
                            <Vertex pos="-1 -2 17" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="" material="bm_grid_blank4" texgens="0 1 0 512 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1" album="" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 0 -1 -384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0 -0.447214 0.894427 -19.6774" album="" material="bm_grid_blank4" texgens="1 0 0 -128 0 -1 0 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 17" album="" material="bm_grid_blank4" texgens="-1 0 0 384 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="458" owner="0" type="0" pos="-34 3 -4" rot="1 0 0 0" scale="" transform="1 0 0 -34 0 1 0 3 0 0 1 -4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 0 15" />
                            <Vertex pos="3 0 -15" />
                            <Vertex pos="3 -3 15" />
                            <Vertex pos="3 -3 -15" />
                            <Vertex pos="-3 0 15" />
                            <Vertex pos="-3 0 -15" />
                            <Vertex pos="-3 -3 15" />
                            <Vertex pos="-3 -3 -15" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -3" album="Blasted" material="bm_stripe_caution2" texgens="0 1 1.5 1024 0 0 -1 640.001 0 0.75 0.75" texRot="0" texScale="0.75 0.75" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -3" album="" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -3" album="" material="bm_grid_blank4" texgens="1 0 0 128 0 0 -1 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -15" album="" material="bm_tile02_B" texgens="1 0 0 768 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -15" album="" material="bm_grid_blank4" texgens="-1 0 0 128 0 -1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="459" owner="5" type="999" pos="-39.5 -32 9.25" rot="1 0 0 0" scale="" transform="1 0 0 -39.5 0 1 0 -32 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 1.75" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="0.5 -1 1.75" />
                            <Vertex pos="0.5 -1 -0.25" />
                            <Vertex pos="-1.5 1 1.75" />
                            <Vertex pos="-1.5 1 -0.25" />
                            <Vertex pos="-1.5 -1 1.75" />
                            <Vertex pos="-1.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_basher_side" texgens="0 1 0 256 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_basher_side" texgens="0 -1 0 256 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_basher" texgens="-1 0 0 128 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_basher" texgens="1 0 0 384 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="Blasted" material="bm_basher_top" texgens="1 0 0 384 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_basher_top" texgens="-1 0 0 128 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="460" owner="9" type="999" pos="-23.5 -31 8.25" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -31 0 0 1 8.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.5 1 1.75" />
                            <Vertex pos="0.5 1 -0.25" />
                            <Vertex pos="0.5 -1 1.75" />
                            <Vertex pos="0.5 -1 -0.25" />
                            <Vertex pos="-1.5 1 1.75" />
                            <Vertex pos="-1.5 1 -0.25" />
                            <Vertex pos="-1.5 -1 1.75" />
                            <Vertex pos="-1.5 -1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -0.5" album="Blasted" material="bm_basher" texgens="0 1 0 256 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -1.5" album="Blasted" material="bm_basher" texgens="0 -1 0 256 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -1" album="Blasted" material="bm_basher_side" texgens="-1 0 0 128 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -1" album="Blasted" material="bm_basher_side" texgens="1 0 0 384 0 0 -1 448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -1.75" album="Blasted" material="bm_basher_top" texgens="1 0 0 384 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_basher_top" texgens="-1 0 0 128 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="461" owner="0" type="0" pos="-23.5 -34 8.75" rot="1 0 0 0" scale="" transform="1 0 0 -23.5 0 1 0 -34 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.5 0.125 -0.625" />
                            <Vertex pos="-3.5 0.125 -1.125" />
                            <Vertex pos="-3.5 0 -0.75" />
                            <Vertex pos="-3.5 0 -1.25" />
                            <Vertex pos="-7.5 0.125 0.375" />
                            <Vertex pos="-7.5 0.125 -0.125" />
                            <Vertex pos="-7.5 0 0.25" />
                            <Vertex pos="-7.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 3.5" album="Blasted" material="bm_wood" texgens="0 1 0 -8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 -7.5" album="Blasted" material="bm_wood" texgens="0 -1 0 8704 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.125" album="Blasted" material="bm_wood" texgens="-1 0 0 6016 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -6016 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="0.174078 -0.696311 0.696311 1.1315" album="Blasted" material="bm_wood" texgens="1 0 0 -6016 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="-0.174078 0.696311 -0.696311 -1.47966" album="Blasted" material="bm_wood" texgens="-1 0 0 6016 0 -1 0 8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="462" owner="0" type="0" pos="-8 19 1.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 19 0 0 1 1.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.5 0.25 0.25" />
                            <Vertex pos="7.5 0.25 -0.25" />
                            <Vertex pos="7.5 0 0.25" />
                            <Vertex pos="7.5 0 -0.25" />
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 0 0.25" />
                            <Vertex pos="2.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7.5" album="Blasted" material="bm_trim" texgens="0 1 0 4864 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_trim" texgens="0 -1 0 -4864 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2048 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_trim" texgens="1 0 0 -2048 0 0 -1 -448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2048 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2048 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="463" owner="0" type="0" pos="-8 24.5 3.75" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 24.5 0 0 1 3.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.5 0.5 0.25" />
                            <Vertex pos="7.5 0.5 -0.25" />
                            <Vertex pos="7.5 0.25 0.25" />
                            <Vertex pos="7.5 0.25 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7.5" album="Blasted" material="bm_trim" texgens="0 1 0 6272 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_trim" texgens="0 -1 0 -6272 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 2048 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2048 0 0 -1 -960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -2048 0 -1 0 -6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 2048 0 -1 0 -6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="464" owner="0" type="0" pos="68.5 24.5 8.75" rot="1 0 0 0" scale="" transform="1 0 0 68.5 0 1 0 24.5 0 0 1 8.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.5 0.25" />
                            <Vertex pos="7 0.5 -0.25" />
                            <Vertex pos="7 0.25 0.25" />
                            <Vertex pos="7 0.25 -0.25" />
                            <Vertex pos="2.5 0.5 0.25" />
                            <Vertex pos="2.5 0.5 -0.25" />
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_trim" texgens="0 1 0 6272 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_trim" texgens="0 -1 0 -6272 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 -17536 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.25" album="Blasted" material="bm_trim" texgens="1 0 0 17536 0 0 -1 -2240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 17536 0 -1 0 -6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -17536 0 -1 0 -6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="465" owner="0" type="0" pos="68.5 11 6.75" rot="1 0 0 0" scale="" transform="1 0 0 68.5 0 1 0 11 0 0 1 6.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7 0.25 0.25" />
                            <Vertex pos="7 0.25 -0.25" />
                            <Vertex pos="7 0 0.25" />
                            <Vertex pos="7 0 -0.25" />
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                            <Vertex pos="2 0 0.25" />
                            <Vertex pos="2 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -7" album="Blasted" material="bm_trim" texgens="0 1 0 2816 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="Blasted" material="bm_trim" texgens="0 -1 0 -2816 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -17536 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_trim" texgens="1 0 0 17536 0 0 -1 -1728 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 17536 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 -17536 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="466" owner="0" type="0" pos="64 4.5 12.25" rot="1 0 0 0" scale="" transform="1 0 0 64 0 1 0 4.5 0 0 1 12.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5 -7 0.25" />
                            <Vertex pos="5 -7 -2.75" />
                            <Vertex pos="5 -7.5 0.25" />
                            <Vertex pos="5 -7.5 -3.25" />
                            <Vertex pos="4.5 -7 0.25" />
                            <Vertex pos="4.5 -7 -2.75" />
                            <Vertex pos="4.5 -7.5 0.25" />
                            <Vertex pos="4.5 -7.5 -3.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -5" album="" material="bm_edge_white" texgens="0 1 0 128 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 -0 0 4.5" album="" material="bm_edge_white" texgens="0 -1 0 0 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 7" album="" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -7.5" album="" material="bm_edge_white" texgens="1 0 0 -640 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="" material="bm_edge_white" texgens="1 0 0 -640 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0.707107 -0.707107 3.0052" album="" material="bm_edge_white" texgens="-1 0 0 768 0 -1 0 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="467" owner="0" type="0" pos="-5.5 -37 0.75" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 -37 0 0 1 0.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.25 0.25" />
                            <Vertex pos="9 0.25 -0.25" />
                            <Vertex pos="9 0 0.25" />
                            <Vertex pos="9 0 -0.25" />
                            <Vertex pos="2.5 0.25 0.25" />
                            <Vertex pos="2.5 0.25 -0.25" />
                            <Vertex pos="2.5 0 0.25" />
                            <Vertex pos="2.5 0 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="Blasted" material="bm_trim" texgens="0 1 0 -9472 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2.5" album="Blasted" material="bm_trim" texgens="0 -1 0 9472 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 1408 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0" album="Blasted" material="bm_trim" texgens="1 0 0 -1408 0 0 -1 -192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -1408 0 -1 0 9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 1408 0 -1 0 9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="468" owner="0" type="0" pos="-5.5 -15.5 -3.25" rot="1 0 0 0" scale="" transform="1 0 0 -5.5 0 1 0 -15.5 0 0 1 -3.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9 0.5 0.25" />
                            <Vertex pos="9 0.5 -0.25" />
                            <Vertex pos="9 0.25 0.25" />
                            <Vertex pos="9 0.25 -0.25" />
                            <Vertex pos="2 0.5 0.25" />
                            <Vertex pos="2 0.5 -0.25" />
                            <Vertex pos="2 0.25 0.25" />
                            <Vertex pos="2 0.25 -0.25" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -9" album="Blasted" material="bm_trim" texgens="0 1 0 -3968 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 2" album="Blasted" material="bm_trim" texgens="0 -1 0 3968 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.5" album="Blasted" material="bm_trim" texgens="-1 0 0 1408 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -1408 0 0 -1 832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.25" album="Blasted" material="bm_trim" texgens="1 0 0 -1408 0 -1 0 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.25" album="Blasted" material="bm_trim" texgens="-1 0 0 1408 0 -1 0 3968 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
